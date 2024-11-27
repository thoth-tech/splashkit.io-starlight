using SplashKitSDK;
using static SplashKitSDK.SplashKit;

OpenWindow("Circle Radius", 800, 600);
ClearScreen();

// Set position for the circle
double x_position = 400;
double y_position = 300;

 //Create a circle A at the position (x_position, y_position)
Circle A = CircleAt(x_position, y_position, 200);

// Find the radius of the circle A
double radius = CircleRadius(A);

//Draw the Circle
DrawCircle(Color.Red, x_position, y_position, radius);
    
string text = "Radius: " + radius.ToString();
// Print result on window
DrawText(text, Color.Black, "NORMAL_FONT", 20, 100, 100);

// Create a point at position (400,300)
Point2D Point = PointAt(400, 300);

RefreshScreen();
Delay(4000);
CloseAllWindows();