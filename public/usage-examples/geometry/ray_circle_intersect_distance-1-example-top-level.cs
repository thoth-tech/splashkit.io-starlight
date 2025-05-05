using SplashKitSDK;
using static SplashKitSDK.SplashKit;

// Ppens a new window
Window window = new Window("Distance From Ray To Circle", 800, 600);

// Defines a laser beam from the left edge of the screen to the right
Point2D rayOrigin = PointAt(0, 300);
Point2D rayEnd = PointAt(800, 100);
Vector2D rayDirection = UnitVector(VectorTo(rayEnd));

// Defines a circle at the center with radius 100
Circle targetCircle = new Circle()
{
    Center = PointAt(400, 300),
    Radius = 100
};

while (!QuitRequested())
{
    ClearScreen();

    // draws the laser beam in blue
    DrawLine(Color.Blue, rayOrigin, rayEnd);

    // draws the target circle in red
    DrawCircle(Color.Red, targetCircle);

    // checks for intersection and calculates distance
    float distance = RayCircleIntersectDistance(rayOrigin, rayDirection, targetCircle);

    // displays the distance to the circle
    DrawText($"Distance to circle: {distance}", Color.Black, 100, 100);

    RefreshScreen(60);
}
