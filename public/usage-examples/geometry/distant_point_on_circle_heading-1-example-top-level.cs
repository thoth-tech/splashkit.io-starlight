using SplashKitSDK;
using static SplashKitSDK.SplashKit;

OpenWindow("Laser Passing Through Shield", 800, 600);

// Declare variables
Point2D playerPosition = PointAt(0, 0);
Circle shield = CircleAt(400, 300, 100);
Point2D aimPoint;
Vector2D heading;
float entryDistance;
Point2D entryPoint;
Point2D exitPoint = PointAt(0, 0);

while (!QuitRequested())
{
    ProcessEvents();

    // Calculate laser heading using mouse position
    aimPoint = MousePosition();
    heading = UnitVector(VectorPointToPoint(playerPosition, aimPoint));

    // Calculate distance from player to shield and point of entry
    entryDistance = RayCircleIntersectDistance(playerPosition, heading, shield);
    entryPoint = PointAt(playerPosition.X + heading.X * entryDistance, playerPosition.Y + heading.Y * entryDistance);

    // Draw the shield (circle) and laser (line)
    ClearScreen(ColorWhite());
    DrawCircle(ColorBlue(), shield);
    DrawLine(ColorRed(), playerPosition, aimPoint);

    if (entryDistance > 0)
    {
        // Find exit point of laser
        if (DistantPointOnCircleHeading(playerPosition, shield, heading, ref exitPoint))
        {
            // Draw entry and exit points and line between entry and exit
            FillCircle(ColorOrange(), entryPoint.X, entryPoint.Y, 5);
            FillCircle(ColorGreen(), exitPoint.X, exitPoint.Y, 5);
            DrawLine(ColorPurple(), entryPoint, exitPoint);
        }
    }
    RefreshScreen(60);
}