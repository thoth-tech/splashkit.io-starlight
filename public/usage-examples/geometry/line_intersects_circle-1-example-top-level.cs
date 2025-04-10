using SplashKitSDK;
using static SplashKitSDK.SplashKit;

OpenWindow("Line Intersects Circle", 800, 600);

//Define points for the line
Point2D startPoint = new Point2D() { X = 100, Y = 100, };
Point2D endPoint = new Point2D() { X = 700, Y = 500, };

//Define Circle
Circle circle = CircleAt(400, 300, 100);

//Draw a circle
DrawCircle(ColorRed(), circle);

//Draw a line
Line line = LineFrom(startPoint, endPoint);
DrawLine(ColorBlue(), line);

//Check for intersection
bool intersect = LineIntersectsCircle(line, circle);

//Display intersection results
DrawText("Line and circle intersect: " + (intersect ? "Yes" : "No"), ColorBlack(), 400, 100);

RefreshScreen();
Delay(5000);

CloseAllWindows();
