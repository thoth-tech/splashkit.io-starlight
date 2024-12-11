using SplashKitSDK;
using static SplashKitSDK.SplashKit;

OpenWindow("Point At Origin", 800, 600);
ClearScreen();

// Create a point at origin
Point2D Point = PointAtOrigin();

// Create circle at the origin point
FillCircle(Color.Red, Point.X, Point.Y, 4);

RefreshScreen();
Delay(4000);
CloseAllWindows();
     


