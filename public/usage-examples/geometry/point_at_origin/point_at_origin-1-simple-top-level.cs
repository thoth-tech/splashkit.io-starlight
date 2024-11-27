using SplashKitSDK;
using static SplashKitSDK.SplashKit;

OpenWindow("Point At Origin", 800, 600);
ClearScreen();

// Create circle at the origin point
FillCircle(Color.Red, 0, 0, 4);

// Create a point at origin
Point2D Point = PointAtOrigin();

RefreshScreen();
Delay(4000);
CloseAllWindows();
     


