using SplashKitSDK;
using static SplashKitSDK.SplashKit;

OpenWindow("Rectangle Ray Intersection", 800, 600);

// Define the starting point of the ray
Point2D rayStart = PointAt(100, 300);

// Define the direction of the ray
Vector2D rayDirection = VectorFromAngle(0, 1);

// Create a rectangle in the path of the ray
Rectangle rect = RectangleFrom(450, 250, 150, 100);

// Store the point and distance where the ray hits the rectangle
Point2D hitPoint = new Point2D();
double hitDistance = 0;

// Check if the ray intersects with the rectangle
bool hit = RectangleRayIntersection(rayStart, rayDirection, rect, ref hitPoint, ref hitDistance);

while (!QuitRequested())
{
    ProcessEvents();
    ClearScreen(ColorWhite());

    // Draw the rectangle
    DrawRectangle(ColorBlue(), rect);

    // Draw the ray as a long line
    DrawLine(
        ColorBlack(),
        rayStart.X,
        rayStart.Y,
        rayStart.X + rayDirection.X * 700,
        rayStart.Y + rayDirection.Y * 700
    );

    // If the ray hits the rectangle, draw the hit point
    if (hit)
    {
        FillCircle(ColorRed(), hitPoint.X, hitPoint.Y, 6);
    }

    RefreshScreen(60);
}