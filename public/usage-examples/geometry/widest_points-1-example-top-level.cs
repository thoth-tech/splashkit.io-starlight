using SplashKitSDK;
using static SplashKitSDK.SplashKit;

OpenWindow("Widest Points on a Circle", 800, 600);

Circle demoCircle = CircleAt(400, 300, 120);

while (!QuitRequested())
{
    ProcessEvents();

    // Use the mouse position to define the direction vector
    Point2D center = CenterPoint(demoCircle);
    Point2D mousePt = MousePosition();
    Vector2D along = VectorPointToPoint(center, mousePt);

    // Calculate the two points on the circle along the vector
    Point2D pt1 = new Point2D();
    Point2D pt2 = new Point2D();
    WidestPoints(demoCircle, along, ref pt1, ref pt2);

    ClearScreen(ColorWhite());

    // Draw the circle and the direction being tested
    DrawCircle(ColorBlack(), demoCircle);
    DrawLine(ColorGray(), center, mousePt);

    // Draw the widest points returned by the function
    DrawLine(ColorBlue(), pt1, pt2);
    FillCircle(ColorRed(), pt1.X, pt1.Y, 6);
    FillCircle(ColorRed(), pt2.X, pt2.Y, 6);

    DrawText("Move the mouse to change the vector.", ColorBlack(), 20, 20);
    DrawText("The red points are the widest points on the circle.", ColorBlue(), 20, 50);

    RefreshScreen(60);
}