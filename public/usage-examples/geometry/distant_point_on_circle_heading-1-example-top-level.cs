using SplashKitSDK;
using static SplashKitSDK.SplashKit;

// Open a new 800x600 window
Window window = new Window("Ray Exit Point From A Circle", 800, 600);

// Define a laser beam starting from the top-left toward bottom-right
Point2D rayOrigin = PointAt(0, 0);
Point2D rayEnd = PointAt(800, 500);
Vector2D rayDirection = UnitVector(VectorTo(rayEnd));

// Create a circle centered in the window with radius 100
Circle targetCircle = new Circle()
{
    Center = PointAt(400, 300),
    Radius = 100
};

Point2D exitPoint = PointAt(0, 0);

while (!QuitRequested())
{
    ClearScreen(Color.White);

    // Draw the laser beam
    DrawLine(Color.Red, rayOrigin, rayEnd);

    // Draw the target circle
    DrawCircle(Color.Blue, targetCircle);

    // Try to find the exit point on the circle along the heading
    if (DistantPointOnCircleHeading(rayOrigin, targetCircle, rayDirection, ref exitPoint))
    {
        // If a valid exit point is found, draw it
        FillCircle(Color.Green, exitPoint.X, exitPoint.Y, 5);
    }

    RefreshScreen(60);
}
