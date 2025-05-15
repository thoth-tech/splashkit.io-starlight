using SplashKitSDK;
using static SplashKitSDK.SplashKit;

// Open a window for the circle intersection demo
OpenWindow("Background Change Circles", 600, 600);

// Calculate static circle’s center and radius
var center        = ScreenCenter();
float circleCenterX = (float)center.X;
float circleCenterY = (float)center.Y;
const float circleRadius = 80f;

// Main loop runs until the user closes the window
while (!QuitRequested())
{
    ProcessEvents();

    // Update moving circle position based on mouse
    var mousePos = MousePosition();
    float mouseX = (float)mousePos.X;
    float mouseY = (float)mousePos.Y;

    // Change background when circles intersect
    if (CirclesIntersect(circleCenterX, circleCenterY, circleRadius, mouseX, mouseY, circleRadius))
    {
        ClearScreen(ColorRed());
    }
    else
    {
        ClearScreen(ColorWhite());
    }

    // Draw static and moving circles
    FillCircle(ColorBlue(),  circleCenterX, circleCenterY, circleRadius);
    FillCircle(ColorGreen(), mouseX, mouseY, circleRadius);

    // Refresh at 30 FPS for smooth animation
    RefreshScreen(30);
}

// Clean up and close
CloseAllWindows();
