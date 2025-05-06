using SplashKitSDK;
using static SplashKitSDK.SplashKit;

// Open a window
Window window = new Window("Laser Passing Through Shield", 800, 600);

// Fixed player position
Point2D playerPosition = PointAt(0, 0);

// Shield represented by a circle
Circle shield = new Circle()
{
    Center = PointAt(400, 300),
    Radius = 100
};

// Points for entry and exit on the shield
Point2D entryPoint = PointAt(0, 0);
Point2D exitPoint = PointAt(0, 0);

while (!QuitRequested())
{
    ProcessEvents();
    ClearScreen(Color.White);

    // Draw the shield
    DrawCircle(Color.Blue, shield);

    // Get current mouse position
    Point2D aimPoint = MousePosition();

    // Draw aiming laser
    DrawLine(Color.Red, playerPosition, aimPoint);

    // Calculate laser heading
    Vector2D heading = UnitVector(VectorPointToPoint(playerPosition, aimPoint));

    // Find entry point (first intersection)
    float entryDistance = RayCircleIntersectDistance(playerPosition, heading, shield);

    if (entryDistance > 0)
    {
        // Draw entry point
        entryPoint = PointAt(
            playerPosition.X + heading.X * entryDistance,
            playerPosition.Y + heading.Y * entryDistance
        );
        FillCircle(Color.Orange, entryPoint.X, entryPoint.Y, 5);

        // Find exit point using distant_point_on_circle_heading
        if (DistantPointOnCircleHeading(playerPosition, shield, heading, ref exitPoint))
        {
            FillCircle(Color.Green, exitPoint.X, exitPoint.Y, 5);

            // Draw line between entry and exit
            DrawLine(Color.Purple, entryPoint, exitPoint);
        }
    }

    RefreshScreen(60);
}
