// I am drawing lines on the window by clicking a start point and an end point.
// Left-click once for start; left-click again for end; C clears; ESC is quitting.

using SplashKitSDK;
using static SplashKitSDK.SplashKit;
using System.Collections.Generic;

const int windowWidth = 720, windowHeight = 405;
OpenWindow("Draw Line — point to point on window", windowWidth, windowHeight);

// I am keeping finished segments
var segments = new List<(double x1, double y1, double x2, double y2)>();

bool hasStart = false;
double sx = 0.0, sy = 0.0;

while (!QuitRequested())
{
    ProcessEvents();

    if (KeyTyped(KeyCode.EscapeKey))
    {
        break;
    }
    if (KeyTyped(KeyCode.CKey))
    {
        segments.Clear();
        hasStart = false;
    }

    if (MouseClicked(MouseButton.LeftButton))
    {
        double mx = MouseX();
        double my = MouseY();

        if (!hasStart)
        {
            hasStart = true;
            sx = mx;
            sy = my;
        }
        else
        {
            segments.Add((sx, sy, mx, my));
            hasStart = false;
        }
    }

    ClearScreen(ColorWhite());

    foreach (var s in segments)
    {
        DrawLine(ColorNavy(), s.x1, s.y1, s.x2, s.y2);
    }

    if (hasStart)
    {
        double mx = MouseX();
        double my = MouseY();
        DrawLine(ColorOrangeRed(), sx, sy, mx, my);
        FillCircle(ColorOrangeRed(), sx, sy, 3);
    }

    DrawText("Click: start/end   C: clear   ESC: quit",
             ColorBlack(), 16, 16);

    RefreshScreen(60);
}