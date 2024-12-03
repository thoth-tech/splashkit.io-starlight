using SplashKitSDK;
using static SplashKitSDK.SplashKit;

// Variable Declarations
Point2D MousePoint;
Rectangle Boundary = RectangleFrom(150, 150, 300, 100);

OpenWindow("Cursor Jail", 600, 600);

while (!QuitRequested())
{
    ProcessEvents();
    // Get mouse position and draw boundary to screen
    MousePoint = MousePosition();
    ClearScreen(ColorGreen());
    FillRectangle(ColorWhite(), Boundary);

    // Check if mouse is in the boundary
    if (!PointInRectangle(MousePoint, Boundary))
    {
        // Flash screen red and blue if mouse has escaped boundary
        ClearScreen(ColorDarkRed());
        FillRectangle(ColorWhite(), Boundary);
        DrawText("JAILBREAK", ColorBlack(), 250.0, 400.0);
        RefreshScreen(2);
        ClearScreen(ColorRoyalBlue());
        FillRectangle(ColorWhite(), Boundary);
        RefreshScreen(2);
    }
    RefreshScreen();
}

CloseAllWindows();