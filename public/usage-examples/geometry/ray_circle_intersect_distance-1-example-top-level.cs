using static SplashKitSDK.SplashKit;

// opens a new 800 * 600 window
Window window = new Window("Ray-Circle Intersect Distance", 800, 600);

// sets the starting point of the ray on the left side of the screen
Point2D rayOrigin = PointAt(100, 200);

// creates a direction vector pointing toward the right and slightly down
Vector2D rayDirection = UnitVector(VectorTo(PointAt(700, 300)));

// creates a red circle at the center with radius 100
Circle circleObj = new Circle()
{
    Center = PointAt(400, 300),
    Radius = 100
};

// keeps looping until the user closes the window
while (!QuitRequested())
{
    // fills the background with white
    ClearScreen(Color.White);

    // calculates the laser end point
    Point2D rayEnd = PointOffsetBy(rayOrigin, VectorMultiply(rayDirection, 800));

    // draws the laser beam in blue
    DrawLine(Color.Blue, rayOrigin, rayEnd);

    // draws the target circle in red
    DrawCircle(Color.Red, circleObj.Center.X, circleObj.Center.Y, circleObj.Radius);

    // checks for intersection and calculates distance
    float distance = RayCircleIntersectDistance(rayOrigin, rayDirection, circleObj);

    // if hit detected, draws a green dot at the impact point
    if (distance > 0)
    {
        Vector2D scaled = VectorMultiply(rayDirection, distance);
        Point2D hitPoint = PointOffsetBy(rayOrigin, scaled);
        FillCircle(Color.Green, hitPoint.X, hitPoint.Y, 5);
    }

    // updates the screen at 60 FPS
    RefreshScreen(60);
}
