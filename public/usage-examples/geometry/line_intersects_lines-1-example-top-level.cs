using System.Collections.Generic;
using SplashKitSDK;

// open a window
Window window = new Window("Line Intersects Lines - Interactive Demo", 800, 600);

// create three static lines to check for intersection
Line line1 = SplashKit.LineFrom(100, 150, 700, 150);
Line line2 = SplashKit.LineFrom(100, 300, 700, 300);
Line line3 = SplashKit.LineFrom(100, 450, 700, 450);

List<Line> linesToCheck = new List<Line> { line1, line2, line3 };

while (!SplashKit.WindowCloseRequested(window))
{
    SplashKit.ProcessEvents();

    // intersecting line from origin to mouse position
    Line intersectingLine = SplashKit.LineFrom(0, 0, SplashKit.MouseX(), SplashKit.MouseY());

    SplashKit.ClearScreen(Color.White);

    SplashKit.DrawLine(Color.Red, intersectingLine);

    // flag to indicate if intersection occurred
    bool anyIntersection = false;

    foreach (Line l in linesToCheck)
    {
        if (SplashKit.LinesIntersect(intersectingLine, l))
        {
            SplashKit.DrawLine(Color.Green, l); // intersecting
            anyIntersection = true;
        }
        else
        {
            SplashKit.DrawLine(Color.Black, l); // not intersecting
        }
    }

    if (anyIntersection)
    {
        SplashKit.DrawText("Intersection Detected!", Color.Green, 20, 20);
    }
    else
    {
        SplashKit.DrawText("No Intersection", Color.Gray, 20, 20);
    }

    SplashKit.DrawText("Move mouse to test intersections", Color.Black, 20, 570);
    SplashKit.RefreshScreen();
}

window.Close();
