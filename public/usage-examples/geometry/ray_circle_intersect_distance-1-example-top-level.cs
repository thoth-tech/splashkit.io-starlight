using SplashKitSDK;
using static SplashKitSDK.SplashKit;

// Open a new window
Window window = new Window("Laser Collision with Circle", 800, 600);

// Initialize the player position
Point2D playerPos = PointAt(0, 0);

// Variables to store the latest shot data
Point2D lastTarget = playerPos;
Vector2D lastDirection = VectorTo(0, 0);
float lastHitDistance = -1;

// Define the target circle
Circle target = new Circle()
{
    Center = PointAt(400, 300),
    Radius = 100
};

while (!QuitRequested())
{
    ProcessEvents();
    ClearScreen();

    // Draw the target circle
    DrawCircle(Color.Blue, target);

    // Fire a laser when the mouse is clicked
    if (MouseClicked(MouseButton.LeftButton))
    {
        // Update the target position based on the mouse position
        lastTarget = MousePosition();
        lastDirection = UnitVector(VectorPointToPoint(playerPos, lastTarget));

        // Check for intersection and calculate hit distance
        lastHitDistance = RayCircleIntersectDistance(playerPos, lastDirection, target);
    }

    // If a shot has been made, draw the laser and hit point
    if (lastHitDistance >= 0)
    {
        // Draw the laser beam
        DrawLine(Color.Red, playerPos, lastTarget);

        // Draw the impact point
        if (lastHitDistance > 0)
        {
            FillCircle(Color.Green, playerPos.X + lastDirection.X * lastHitDistance, playerPos.Y + lastDirection.Y * lastHitDistance, 5);
        }
    }

    RefreshScreen(60);
}
