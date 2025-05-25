using static SplashKitSDK.SplashKit;

OpenWindow("Mouse Circle Overlapping Quad", 800, 600);

// Define quad corners using full type names
SplashKitSDK.Point2D topLeft = PointAt(300, 200);
SplashKitSDK.Point2D topRight = PointAt(500, 200);
SplashKitSDK.Point2D bottomRight = PointAt(500, 400);
SplashKitSDK.Point2D bottomLeft = PointAt(300, 400);

// Create quad
SplashKitSDK.Quad fixedQuad = QuadFrom(topLeft, topRight, bottomRight, bottomLeft);

// Declare variables
float radius = 30;
SplashKitSDK.Point2D mouse;
SplashKitSDK.Circle mouseCircle;
bool isIntersecting;
SplashKitSDK.Color fillColor;

while (!QuitRequested())
{
    ProcessEvents();
    ClearScreen(ColorWhite());

    mouse = MousePosition();
    mouseCircle = CircleAt(mouse.X, mouse.Y, radius);

    isIntersecting = CircleQuadIntersect(mouseCircle, fixedQuad);

    if (isIntersecting)
    {
        fillColor = ColorRed();
    }
    else
    {
        fillColor = ColorGreen();
    }

    FillTriangle(fillColor, topLeft.X, topLeft.Y, topRight.X, topRight.Y, bottomRight.X, bottomRight.Y);
    FillTriangle(fillColor, topLeft.X, topLeft.Y, bottomLeft.X, bottomLeft.Y, bottomRight.X, bottomRight.Y);

    DrawCircle(ColorBlack(), mouseCircle);
    RefreshScreen();
}