using static SplashKitSDK.SplashKit;

OpenWindow("Mouse Circle vs Rectangle Area", 800, 600);

SplashKitSDK.Point2D topLeft = PointAt(300, 200);
SplashKitSDK.Point2D topRight = PointAt(500, 200);
SplashKitSDK.Point2D bottomRight = PointAt(500, 400);
SplashKitSDK.Point2D bottomLeft = PointAt(300, 400);

SplashKitSDK.Quad fixedQuad = QuadFrom(topLeft, topRight, bottomRight, bottomLeft);

float radius = 30;
SplashKitSDK.Point2D mouse;
SplashKitSDK.Circle mouseCircle;
bool isIntersecting;
while (!WindowCloseRequested("Mouse Circle vs Rectangle Area"))
{
    ProcessEvents();
    ClearScreen(ColorDarkSlateGray());

    mouse = MousePosition();
    mouseCircle = CircleAt(mouse.X, mouse.Y, radius);

    // Checks if a circle intersects with the given quad using SplashKit's geometry function
    isIntersecting = CircleQuadIntersect(mouseCircle, fixedQuad);

    if (isIntersecting)
    {
        FillTriangle(ColorRed(), topLeft.X, topLeft.Y, topRight.X, topRight.Y, bottomRight.X, bottomRight.Y);
        FillTriangle(ColorRed(), topLeft.X, topLeft.Y, bottomLeft.X, bottomLeft.Y, bottomRight.X, bottomRight.Y);
    }
    else
    {
        FillTriangle(ColorGreen(), topLeft.X, topLeft.Y, topRight.X, topRight.Y, bottomRight.X, bottomRight.Y);
        FillTriangle(ColorGreen(), topLeft.X, topLeft.Y, bottomLeft.X, bottomLeft.Y, bottomRight.X, bottomRight.Y);
    }

    DrawCircle(ColorWhite(), mouseCircle);
    RefreshScreen(60);
}