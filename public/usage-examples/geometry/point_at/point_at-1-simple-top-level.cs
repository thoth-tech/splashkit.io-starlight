using SplashKitSDK;
using static SplashKitSDK.SplashKit;

OpenWindow("Point At", 800, 600);
ClearScreen();

// Draw the circle at the point
FillCircle(Color.Red, 400, 300, 4);

// Create a point at position (400,300)
Point2D Point = PointAt(400, 300);

RefreshScreen();
Delay(4000);
CloseAllWindows();
     


