using System.Collections.Generic;
using SplashKitSDK;
using static SplashKitSDK.SplashKit;

OpenWindow("Click to Place Markers", 800, 600);

List<Point2D> clicks = new();

while (!QuitRequested())
{
    ProcessEvents();

    // Add a marker where the left mouse button was clicked
    if (MouseClicked(MouseButton.LeftButton))
    {
        clicks.Add(MousePosition());
    }

    ClearScreen(ColorWhite());

    foreach (Point2D pt in clicks)
    {
        FillCircle(ColorRed(), pt.X, pt.Y, 8);
    }

    RefreshScreen(60);
}

CloseAllWindows();