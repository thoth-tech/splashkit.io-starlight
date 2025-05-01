using static SplashKitSDK.SplashKit;
using SplashKitSDK;

OpenWindow("Circle-Triangle Intersect", 600, 600);

// A fixed triangle is placed as the target.
Triangle target = TriangleFrom(300, 100, 250, 300, 350, 300);

// A circle moves with arrow keys.
Circle playerCircle = new Circle
{
    Radius = 20,
    Center = PointAt(100, 100)
}; 

while (!WindowCloseRequested("Circle-Triangle Intersect"))
{
    ProcessEvents();

    if (KeyDown(KeyCode.UpKey)) playerCircle.Center.Y -= 0.5;
    if (KeyDown(KeyCode.DownKey)) playerCircle.Center.Y += 0.5;
    if (KeyDown(KeyCode.LeftKey)) playerCircle.Center.X -= 0.5;
    if (KeyDown(KeyCode.RightKey)) playerCircle.Center.X += 0.5;

    ClearScreen(Color.White);
    DrawTriangle(Color.Black, target);

    bool intersects = CircleTriangleIntersect(playerCircle, target);
    Color circleColor = intersects ? Color.Green : Color.Red;

    DrawCircle(circleColor, playerCircle.Center.X, playerCircle.Center.Y, playerCircle.Radius);

    if (intersects)
    {
        DrawText("Circle is Intersecting the triangle", Color.Black, 170, 20);
    }

    RefreshScreen(60);
}
