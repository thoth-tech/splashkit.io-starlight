using SplashKitSDK;
using static SplashKitSDK.SplashKit;

// Open a window for the circle-intersection demo
OpenWindow("Background Change Circles", 600, 600);

// Determine the static circle’s center and radius
var centerPoint = ScreenCenter();
float staticCenterX = (float)centerPoint.X;
float staticCenterY = (float)centerPoint.Y;
const float circleRadius = 80f;

// Continue running until the user closes the window
while (!QuitRequested())
{
    ProcessEvents();

    // Get the moving circle’s position from the mouse
    var mousePoint = MousePosition();
    float movingCircleX = (float)mousePoint.X;
    float movingCircleY = (float)mousePoint.Y;

    // Toggle background color when circles overlap
    bool circlesOverlap = CirclesIntersect(
        staticCenterX, staticCenterY, circleRadius,
        movingCircleX,  movingCircleY,  circleRadius
    );
    if (circlesOverlap)
    {
        ClearScreen(ColorRed());
    }
    else
    {
        ClearScreen(ColorWhite());
    }

    // Draw the static and moving circles
    FillCircle(ColorBlue(),  staticCenterX, staticCenterY, circleRadius);
    FillCircle(ColorGreen(), movingCircleX, movingCircleY, circleRadius);

    // Refresh at 30 FPS for smooth animation
    RefreshScreen(30);
}

// Clean up and close
CloseAllWindows();
