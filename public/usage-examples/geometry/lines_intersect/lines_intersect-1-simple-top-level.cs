using static SplashKitSDK.SplashKit;
using SplashKitSDK;

OpenWindow("Lines Intersect", 800, 600);

// Define points for the lines
Point2D startPoint1 = new Point2D() { X = 100, Y = 150 };
Point2D endPoint1 = new Point2D() { X = 500, Y = 550 };

Point2D startPoint2 = new Point2D() { X = 100, Y = 550 };
Point2D endPoint2 = new Point2D() { X = 500, Y = 150 };

Point2D startPoint3 = new Point2D() { X = 550, Y = 150 };
Point2D endPoint3 = new Point2D() { X = 550, Y = 500 };

// Draw the lines
Line demoLine1 = LineFrom(startPoint1, endPoint1);
DrawLine(ColorRed(), demoLine1);
DrawText("A", ColorBlack(), startPoint1.X - 20, startPoint1.Y - 10);

Line demoLine2 = LineFrom(startPoint2, endPoint2);
DrawLine(ColorBlue(), demoLine2);
DrawText("B", ColorBlack(), startPoint2.X - 20, startPoint2.Y - 10);

Line demoLine3 = LineFrom(startPoint3, endPoint3);
DrawLine(ColorGreen(), demoLine3);
DrawText("C", ColorBlack(), startPoint3.X - 20, startPoint3.Y - 10);

// Check intersections
bool intersect1And2 = LinesIntersect(demoLine1, demoLine2);
bool intersect1And3 = LinesIntersect(demoLine1, demoLine3);

// Display intersection results
DrawText("A and B intersect: " + (intersect1And2 ? "Yes" : "No"), ColorBlack(), 150, 130);
DrawText("A and C intersect: " + (intersect1And3 ? "Yes" : "No"), ColorBlack(), 150, 150);

RefreshScreen();
Delay(5000);

CloseAllWindows();

