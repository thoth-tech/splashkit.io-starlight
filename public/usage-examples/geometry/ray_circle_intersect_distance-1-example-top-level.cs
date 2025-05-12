using SplashKitSDK;
using static SplashKitSDK.SplashKit;

OpenWindow("Ray-Circle Intersection Distance", 800, 600);

// Declare variables
Point2D rayOrigin = PointAt(0, 0);
Circle targetCircle = CircleAt(400, 300, 100);
Point2D mousePos;
Vector2D rayHeading;
float distanceToCircle;

while (!QuitRequested())
{
    ProcessEvents();

    // Calculate ray heading from origin to mouse
    mousePos = MousePosition();
    rayHeading = UnitVector(VectorPointToPoint(rayOrigin, mousePos));

    // Find intersection distance between ray and circle
    distanceToCircle = RayCircleIntersectDistance(rayOrigin, rayHeading, targetCircle);

    // Draw scene
    ClearScreen(Color.White);
    DrawCircle(Color.Blue, targetCircle);
    DrawLine(Color.Red, rayOrigin, mousePos);

    if (distanceToCircle > 0)
    {
        Point2D hitPoint = PointAt(rayOrigin.X + rayHeading.X * distanceToCircle,
                                   rayOrigin.Y + rayHeading.Y * distanceToCircle);
        FillCircle(Color.Green, hitPoint.X, hitPoint.Y, 5);
    }

    RefreshScreen(60);
}
