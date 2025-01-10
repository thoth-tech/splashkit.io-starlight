using SplashKitSDK;
using static SplashKitSDK.SplashKit;

// Let user create a circle
WriteLine("Create a circle!");
WriteLine("Center point x1: ");
int x1 = ConvertToInteger(ReadLine());
WriteLine("Center point y1: ");
int y1 = ConvertToInteger(ReadLine());
WriteLine("Radius for circle: ");
int radius = ConvertToInteger(ReadLine());

// Let user create a point
WriteLine("Create a point now!");
WriteLine("x for point: ");
int px1 = ConvertToInteger(ReadLine());
WriteLine("y for point: ");
int py1 = ConvertToInteger(ReadLine());

OpenWindow("Point In Circle", 800, 600);
ClearScreen();

// Create the circle base on the data given by user
Circle A = CircleAt(x1, y1, radius);

// Create the point base on the data given by user
Point2D B = PointAt(px1, py1);

// Draw the circle
DrawCircle(ColorRed(), A);

// Draw the point
FillCircle(ColorGreen(), px1, py1, 4);

// Detect if the point in the circle or not
if (PointInCircle(B, A))
{
    WriteLine("Point in the circle!");
}
else
{
    WriteLine("Point not in the circle!");
}

RefreshScreen();
Delay(4000);
CloseAllWindows();

