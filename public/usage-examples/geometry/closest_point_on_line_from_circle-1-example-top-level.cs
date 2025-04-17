using SplashKitSDK;
using static SplashKitSDK.SplashKit;

Window window = new Window("Closest Point On Line From Circle", 800, 600);

Point2D cursor_pos;
Circle circle_shape = CircleAt(PointAt(250, 150), 100);
Line line_shape;
Point2D closest_point_coordinates;

while (!QuitRequested())
{
    ProcessEvents();
    cursor_pos = MousePosition();
    line_shape = LineFrom(PointAt(300, 400), cursor_pos);

    // Point2D variable stores the x and y coordinates of the closest point between the circle and line
    closest_point_coordinates = ClosestPointOnLineFromCircle(circle_shape, line_shape);

    ClearScreen();
    DrawCircle(ColorBlack(), circle_shape);
    DrawLine(ColorBlack(), line_shape);
    FillCircle(ColorRed(), CircleAt(closest_point_coordinates, 5));

    DrawText("Position of closest point on line from circle: " + PointToString(closest_point_coordinates), ColorBlack(), 110, 500);
    RefreshScreen();
}
window.Close();