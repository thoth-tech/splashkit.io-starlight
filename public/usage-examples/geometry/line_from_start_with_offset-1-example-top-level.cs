using SplashKitSDK;
using static SplashKitSDK.SplashKit;

// Open a 300x300 window
Window window = OpenWindow("Vector Offset Lines", 300, 300);
// Use the center of the window as the start point for lines
Point2D start = PointAt(150, 150);
// Create vectors for up and right
Vector2D vecUp = VectorTo(0.0, -100.0);
Vector2D vecRight = VectorTo(100.0, 0.0);

while (!WindowCloseRequested(window))
{
    ProcessEvents();
    ClearScreen();
    // Draw a red line with the up vector as offset
    DrawLine(ColorRed(), LineFrom(start, vecUp));
    // Draw a blue line with the right vector as offset
    DrawLine(ColorBlue(), LineFrom(start, vecRight));
    RefreshScreen();
}
CloseAllWindows();