using SplashKitSDK;
using static SplashKitSDK.SplashKit;

// Let user enter the radius
WriteLine("Enter Radius for circle: ");
double Radius = ConvertToDouble(ReadLine());

OpenWindow("Circle Radius", 800, 600);
ClearScreen();

// Create a circle at the position (400, 300)
Circle circle = CircleAt(400, 300, Radius);

// Find the radius of the circle 
double radius = CircleRadius(circle);

// Fill the Circle
FillCircle(Color.Red, 400, 300, radius);

// Create a rectangle to show the radius
DrawRectangle(Color.White, 400, 300, radius, radius);

string text = "Radius: " + radius.ToString();

// Print result on window
DrawText(text, Color.Black, "NORMAL_FONT", 20, 100, 100);

RefreshScreen();
Delay(4000);
CloseAllWindows();