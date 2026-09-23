using SplashKitSDK;
using static SplashKitSDK.SplashKit;

OpenWindow("Rectangle Ray Intersection", 800, 600);

Point2D rayStart = PointAt(100, 300);

Vector2D rayDirection = VectorFromAngle(0, 1);

Rectangle rect = RectangleFrom(450, 250, 150, 100);

Point2D hitPoint = new Point2D();
double hitDistance = 0;

// Check once because the ray and rectangle do not move during the loop
bool hit = RectangleRayIntersection(rayStart, rayDirection, rect, ref hitPoint, ref hitDistance);

while (!QuitRequested())
{
    ProcessEvents();
    ClearScreen(ColorWhite());

    DrawRectangle(ColorBlue(), rect);

    DrawLine(
        ColorBlack(),
        rayStart.X,
        rayStart.Y,
        rayStart.X + rayDirection.X * 700,
        rayStart.Y + rayDirection.Y * 700
    );

    if (hit)
    {
        FillCircle(ColorRed(), hitPoint.X, hitPoint.Y, 6);
    }

    RefreshScreen(60);
}

CloseAllWindows();