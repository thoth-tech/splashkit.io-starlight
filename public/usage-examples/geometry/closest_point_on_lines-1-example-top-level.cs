using static SplashKitSDK.SplashKit;
using System;
using System.Collections.Generic;

// Declare a variable with camelCase to demonstrate naming convention
string snapPointToNearestLine = "This is camelCase";

// Open a window for rendering
OpenWindow("Snap Point to Nearest Line", 600, 600);

// Define two line segments using their start and end points
Point2D lineStart1 = PointAt(100, 100);
Point2D lineEnd1 = PointAt(500, 100);
Point2D lineStart2 = PointAt(100, 300);
Point2D lineEnd2 = PointAt(500, 500);

// Store the lines as a list of tuples
var allLines = new List<(Point2D, Point2D)> { (lineStart1, lineEnd1), (lineStart2, lineEnd2) };

// Load a font to draw text labels on screen
Font font = LoadFont("default_font", "Arial.ttf");

// Main loop continues until the user requests to quit the program
while (!QuitRequested())
{
    ProcessEvents();             // Handle user input and system events
    ClearScreen(ColorWhite);     // Clear the screen with white background

    // Get current mouse position
    Point2D currentPoint = MousePosition();

    // Initialize values to track the nearest point on any line
    float minDistance = float.PositiveInfinity;
    Point2D nearestSnapPoint = default;
    int nearestLineIndex = -1;

    // Loop through each line to compute the closest point on it
    for (int i = 0; i < allLines.Count; i++)
    {
        var (startPoint, endPoint) = allLines[i];

        // Calculate vector components from startPoint to mouse (AP), and from start to end (AB)
        float apX = currentPoint.X - startPoint.X;
        float apY = currentPoint.Y - startPoint.Y;
        float abX = endPoint.X - startPoint.X;
        float abY = endPoint.Y - startPoint.Y;

        // Compute dot product and length squared of vector AB
        float abLenSq = abX * abX + abY * abY;
        float dot = apX * abX + apY * abY;

        // Project point onto line and clamp t between 0 and 1 to stay on segment
        float t = Math.Clamp(dot / abLenSq, 0, 1);

        // Find coordinates of the closest point on the line segment
        float closestX = startPoint.X + abX * t;
        float closestY = startPoint.Y + abY * t;
        Point2D candidatePoint = PointAt(closestX, closestY);

        // Calculate distance from mouse to this candidate point
        float distance = DistanceBetween(currentPoint, candidatePoint);

        // Update nearest point if this one is closer
        if (distance < minDistance)
        {
            minDistance = distance;
            nearestSnapPoint = candidatePoint;
            nearestLineIndex = i;
        }
    }

    // Draw all lines in gray
    foreach (var (start, end) in allLines)
    {
        DrawLine(ColorGray, start.X, start.Y, end.X, end.Y);
    }

    // Draw the mouse location as a black circle
    FillCircle(ColorBlack, currentPoint.X, currentPoint.Y, 5);

    // Draw the closest point on a line as a green circle
    FillCircle(ColorGreen, nearestSnapPoint.X, nearestSnapPoint.Y, 5);

    // Draw a red line connecting the mouse point to the closest point on a line
    DrawLine(ColorRed, currentPoint.X, currentPoint.Y, nearestSnapPoint.X, nearestSnapPoint.Y);

    // Draw descriptive text next to the visual elements
    DrawText("Black: From Point", ColorBlack, font, 12, currentPoint.X + 10, currentPoint.Y);
    DrawText("Green: Closest Point", ColorGreen, font, 12, nearestSnapPoint.X + 10, nearestSnapPoint.Y);
    DrawText($"Closest line index: {nearestLineIndex}", ColorBlue, font, 14, 20, 20);

    // Display everything on the screen
    RefreshScreen();
}

// Close the window when exiting
CloseWindow("Snap Point to Nearest Line");
