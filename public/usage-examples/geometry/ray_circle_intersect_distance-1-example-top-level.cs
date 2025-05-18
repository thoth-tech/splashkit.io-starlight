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
    ClearScreen(ColorWhite());
    DrawCircle(ColorBlue(), targetCircle);
    DrawLine(ColorRed(), rayOrigin, mousePos);

    if (distanceToCircle > 0)
    {
        Point2D hitPoint = PointAt(rayOrigin.X + rayHeading.X * distanceToCircle,
                                   rayOrigin.Y + rayHeading.Y * distanceToCircle);
        FillCircle(ColorGreen(), hitPoint.X, hitPoint.Y, 5);

        // Display the distance
        DrawText($"Distance to circle: {distanceToCircle}", ColorBlack(), 10, 10);
    }
    else
    {
        // Display no intersection message
        DrawText("No intersection", ColorBlack(), 10, 10);
    }

    RefreshScreen(60);
}
