// I am drawing lines on the window by clicking a start point and an end point.
// I am left-clicking once for start; I am left-clicking again for end; I am pressing C to clear; I am pressing ESC to quit.

using SplashKitSDK;
using static SplashKitSDK.SplashKit;
using System.Collections.Generic;

// I am opening the window with an ASCII title and explicit size.
OpenWindow("Draw Line - point to point on window", 720, 405);

// I am keeping finished segments so I can redraw them every frame.
var segments = new List<(double x1, double y1, double x2, double y2)>();

// I am remembering whether I have a start point for the current segment.
bool hasStart = false;
double sx = 0.0, sy = 0.0; // I am storing the start point after the first click.

while (!QuitRequested())
{
    ProcessEvents(); // I am polling inputs each frame.

    // I am handling quit and clear.
    if (KeyTyped(KeyCode.EscapeKey))
    {
        break; // I am exiting the loop on ESC.
    }
    if (KeyTyped(KeyCode.CKey))
    {
        segments.Clear(); // I am removing finished segments.
        hasStart = false; // I am cancelling the partial segment as well.
    }

    // I am turning two clicks into one segment.
    if (MouseClicked(MouseButton.LeftButton))
    {
        double mx = MouseX();
        double my = MouseY();

        if (!hasStart)
        {
            // I am recording the start point on first click.
            hasStart = true;
            sx = mx;
            sy = my;
        }
        else
        {
            // I am saving the full segment on second click.
            segments.Add((sx, sy, mx, my));
            hasStart = false;
        }
    }

    // I am rendering the frame.
    ClearScreen(ColorWhite());

    // I am drawing all finished segments in navy.
    foreach (var s in segments)
    {
        DrawLine(ColorNavy(), s.x1, s.y1, s.x2, s.y2);
    }

    // I am previewing the current segment in orange from start to mouse.
    if (hasStart)
    {
        double mx = MouseX();
        double my = MouseY();
        DrawLine(ColorOrangeRed(), sx, sy, mx, my);
        FillCircle(ColorOrangeRed(), sx, sy, 3); // I am marking the start point.
    }

    // I am showing a small HUD with controls.
    DrawText("Click: start/end   C: clear   ESC: quit", ColorBlack(), 16, 16);

    RefreshScreen(60); // I am pacing to ~60 FPS.
}