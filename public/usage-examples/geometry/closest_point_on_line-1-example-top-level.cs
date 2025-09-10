using SplashKitSDK;
using static SplashKitSDK.SplashKit;

Window window = new Window("Closest Point On Line", 800, 600);

// Create line for which our point will be attached to
Line diagonalLine = LineFrom(200, 150, 600, 450);

while (!window.CloseRequested)
{
    ProcessEvents();
    ClearScreen(ColorWhite());
    DrawLine(ColorBlack(), diagonalLine);

    // Use our mouse position for calculating the closest point on line
    Point2D mousePos = MousePosition();
    Point2D closest = ClosestPointOnLine(mousePos, diagonalLine);

    // Visualize the mouse position and the closest point on the line
    FillCircle(ColorRed(), mousePos.X, mousePos.Y, 5);
    FillCircle(ColorGreen(), closest.X, closest.Y, 5);

    RefreshScreen();
}