using System;
using SplashKitSDK;

namespace GuessHiddenPointApp
{
    public class Program
    {
        public static void Main()
        {
            // Open a window with a descriptive name
            SplashKit.OpenWindow("Point on line", 800, 600);

            // Define a horizontal line from point (100, 300) to (700, 300)
            Point2D startPoint = SplashKit.PointAt(100, 300);
            Point2D endPoint = SplashKit.PointAt(700, 300);
            Line baseLine = SplashKit.LineFrom(startPoint, endPoint);

            // Random hidden point on the line
            double hiddenX = SplashKit.Rnd(100, 700);
            Point2D hiddenPoint = SplashKit.PointAt(hiddenX, 300);

            // Run until the user closes the window
            while (!SplashKit.WindowCloseRequested("Hover to Guess the Hidden Point"))
            {
                // Update mouse and keyboard input
                SplashKit.ProcessEvents();

                // Clear the screen before drawing
                SplashKit.ClearScreen(Color.White);

                // Draw the black line
                SplashKit.DrawLine(Color.Black, baseLine);

                // Get current mouse position
                Point2D mouse = SplashKit.MousePosition();

                // Check how close the mouse is to the hidden point
                if (SplashKit.PointPointDistance(mouse, hiddenPoint) <= 8.0)
                {
                    // User found the hidden point
                    SplashKit.DrawCircle(Color.Blue, hiddenPoint.X, hiddenPoint.Y, 5);
                    SplashKit.DrawText("You found the hidden point!", Color.Green, 260, 450);
                }
                else if (SplashKit.PointOnLine(mouse, baseLine, 5.0f))
                {
                    // Mouse is on the line, but not on the hidden point
                    SplashKit.DrawText("You're on the line, but not on the hidden point.", Color.Red, 180, 450);
                }
                else
                {
                    // Mouse is not on the line
                    SplashKit.DrawText("Move your mouse over the line to find the hidden point!", Color.Black, 150, 450);
                }

                // Show the new frame
                SplashKit.RefreshScreen(60);
            }
        }
    }
}
