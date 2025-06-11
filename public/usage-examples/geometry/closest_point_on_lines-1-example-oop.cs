using System;
using System.Collections.Generic;
using SplashKitSDK;

namespace ClosestPointOnLinesExample
{
    public class Program
    {
        public static void Main()
        {
            // Declare a variable with camelCase (used to demonstrate naming style)
            string snapPointToNearestLine = "This is camelCase";

            // Open a graphical window with title and size
            SplashKit.OpenWindow("Snap Point to Nearest Line", 600, 600);

            // Define two lines using their start and end points
            Point2D lineStart1 = SplashKit.PointAt(100, 100);
            Point2D lineEnd1 = SplashKit.PointAt(500, 100);
            Point2D lineStart2 = SplashKit.PointAt(100, 300);
            Point2D lineEnd2 = SplashKit.PointAt(500, 500);

            // Store the lines as a list of tuples (start, end)
            var allLines = new List<(Point2D, Point2D)> { (lineStart1, lineEnd1), (lineStart2, lineEnd2) };

            // Load a font for rendering text
            Font font = SplashKit.LoadFont("default_font", "Arial.ttf");

            // Main loop runs until the user closes the window
            while (!SplashKit.QuitRequested())
            {
                SplashKit.ProcessEvents();         // Handle user input/events
                SplashKit.ClearScreen(Color.White); // Clear the screen with white background

                // Get the current mouse position
                Point2D currentPoint = SplashKit.MousePosition();

                // Initialize values to track the closest point
                float minDistance = float.PositiveInfinity;
                Point2D nearestSnapPoint = default;
                int nearestLineIndex = -1;

                // Loop through each line to find the closest point on any line to the mouse
                for (int i = 0; i < allLines.Count; i++)
                {
                    var (startPoint, endPoint) = allLines[i];

                    // Vector math to project the point onto the line segment
                    float apX = currentPoint.X - startPoint.X;
                    float apY = currentPoint.Y - startPoint.Y;
                    float abX = endPoint.X - startPoint.X;
                    float abY = endPoint.Y - startPoint.Y;

                    float abLenSq = abX * abX + abY * abY;
                    float dot = apX * abX + apY * abY;
                    float t = Math.Clamp(dot / abLenSq, 0, 1); // Clamp t to stay within the segment

                    // Compute the closest point's coordinates
                    float closestX = startPoint.X + abX * t;
                    float closestY = startPoint.Y + abY * t;
                    Point2D candidatePoint = SplashKit.PointAt(closestX, closestY);

                    // Calculate distance between mouse and candidate point
                    float distance = SplashKit.DistanceBetween(currentPoint, candidatePoint);

                    // Update the nearest point if it's closer
                    if (distance < minDistance)
                    {
                        minDistance = distance;
                        nearestSnapPoint = candidatePoint;
                        nearestLineIndex = i;
                    }
                }

                // Draw all the lines in gray
                foreach (var (start, end) in allLines)
                {
                    SplashKit.DrawLine(Color.Gray, start.X, start.Y, end.X, end.Y);
                }

                // Draw the mouse point as a black circle
                SplashKit.FillCircle(Color.Black, currentPoint.X, currentPoint.Y, 5);

                // Draw the closest snap point as a green circle
                SplashKit.FillCircle(Color.Green, nearestSnapPoint.X, nearestSnapPoint.Y, 5);

                // Draw a red line connecting the mouse point to the closest point
                SplashKit.DrawLine(Color.Red, currentPoint.X, currentPoint.Y, nearestSnapPoint.X, nearestSnapPoint.Y);

                // Display text labels next to points
                SplashKit.DrawText("Black: From Point", Color.Black, font, 12, currentPoint.X + 10, currentPoint.Y);
                SplashKit.DrawText("Green: Closest Point", Color.Green, font, 12, nearestSnapPoint.X + 10, nearestSnapPoint.Y);
                SplashKit.DrawText($"Closest line index: {nearestLineIndex}", Color.Blue, font, 14, 20, 20);

                // Refresh the screen to show updates
                SplashKit.RefreshScreen();
            }

            // Close the window once the loop ends
            SplashKit.CloseWindow("Snap Point to Nearest Line");
        }
    }
}
