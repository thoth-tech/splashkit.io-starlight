using SplashKitSDK;
using static SplashKitSDK.SplashKit;

Window window = new Window("Distant Point On Circle", 800, 600);

Point2D cursor_pos;
Circle circle_shape = CircleAt(PointAt(400, 200), 100);
Point2D distant_point_coordinates;

while (!QuitRequested())
{
    ProcessEvents();
    cursor_pos = MousePosition();

    // Point2D variable stores the x and y coordinates of the furthest point between the circle and mouse cursor
    distant_point_coordinates = DistantPointOnCircle(cursor_pos, circle_shape);

    ClearScreen();
    DrawCircle(ColorBlack(), circle_shape);
    FillCircle(ColorRed(), CircleAt(distant_point_coordinates, 5));

    DrawText("Most distant point on circle's circumference from mouse cursor is: " + PointToString(distant_point_coordinates), ColorBlack(), 35, 500);
    RefreshScreen();
}
window.Close();