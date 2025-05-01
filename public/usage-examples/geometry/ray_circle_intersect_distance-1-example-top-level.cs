using SplashKitSDK;
using static SplashKitSDK.SplashKit;

// opens a new 800 * 600 window
Window window = new Window("Distance From Ray To Circle", 800, 600);

// sets the starting point of the ray on the left side of the screen
Point2D rayOrigin = PointAt(0, 300);

// sets the ending point of the ray on the right side of the screen
Point2D rayEnd = PointAt(800, 100);

// creates a direction vector pointing toward the right and slightly up
Vector2D rayDirection = UnitVector(VectorTo(rayEnd));

// creates a red circle at the center with radius 100
Circle circleObj = new Circle()
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
    DrawCircle(Color.Red, circleObj);

    // checks for intersection and calculates distance
    float distance = RayCircleIntersectDistance(rayOrigin, rayDirection, circleObj);

    // displays the distance to the circle
    DrawText($"Distance to circle: {distance}", Color.Black, 100, 100);

    RefreshScreen(60);
}
