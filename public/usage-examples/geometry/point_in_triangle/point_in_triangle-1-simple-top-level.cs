using SplashKitSDK;
using static SplashKitSDK.SplashKit;

// Let user create a triangle
WriteLine("Create a triangle!");
WriteLine("x1: ");
int x1 = ConvertToInteger(ReadLine());
WriteLine("y1: ");
int y1 = ConvertToInteger(ReadLine());
WriteLine("x2: ");
int x2 = ConvertToInteger(ReadLine());
WriteLine("y2: ");
int y2 = ConvertToInteger(ReadLine());
WriteLine("x3: ");
int x3 = ConvertToInteger(ReadLine());
WriteLine("y3: ");
int y3 = ConvertToInteger(ReadLine());

// Let user create a point
WriteLine("Create a point now!");
WriteLine("x for point: ");
int px1 = ConvertToInteger(ReadLine());
WriteLine("y for point: ");
int py1 = ConvertToInteger(ReadLine());

OpenWindow("Point In Triangle", 800, 600);
ClearScreen();

// Create the triangle base on the data given by user
Triangle A = TriangleFrom(x1, y1, x2, y2, x3, y3);

// Create the point base on the data given by user
Point2D B = PointAt(px1, py1);

// Draw the triangle
DrawTriangle(ColorRed(), A);

// Draw the point
FillCircle(ColorGreen(), px1, py1, 4);

// Detect if the point in the triangle or not
if(PointInTriangle(B, A))
{
    WriteLine("Point in the triangle!");
}
else
{
    WriteLine("Point not in the triangle!");
}

RefreshScreen();
Delay(4000);
CloseAllWindows();