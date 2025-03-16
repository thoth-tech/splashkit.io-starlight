using SplashKitSDK;
using static SplashKitSDK.SplashKit;

// Open window
Window window = OpenWindow("Basic Line Drawing", 300, 300);
// Initialise start and end points for line
Point2D start = PointAtOrigin();
Point2D end = PointAtOrigin();

while (!window.CloseRequested)
{
    ProcessEvents();
    // Get start point from cursor on left click and end point on right click
    if (MouseClicked(MouseButton.LeftButton))
    {
        start = MousePosition();
    }
    else if (MouseClicked(MouseButton.RightButton))
    {
        end = MousePosition();
    }
    // Create a line between the points
    Line line = LineFrom(start, end);
    // Draw the line in red
    ClearScreen();
    DrawLine(ColorRed(), line);
    RefreshScreen();
}

CloseAllWindows();