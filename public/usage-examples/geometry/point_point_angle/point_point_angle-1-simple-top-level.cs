using SplashKitSDK;
using static SplashKitSDK.SplashKit;


OpenWindow("Point Point Angle", 800, 600);
ClearScreen();

// Draw the circle at the origin point
FillCircle(Color.Red, 400, 300, 2);

// Define the origin point
Point2D originPoint = PointAt(400, 300);

RefreshScreen();

while (!SplashKit.QuitRequested())
{
    // Get the current mouse position
    Point2D mouse = MousePosition();

    // Calculate the angle between the origin point and the mouse position
    float angle = PointPointAngle(originPoint, mouse);

    // Print angle 
    WriteLine(angle);

    Delay(100); 
}

CloseAllWindows();
     


