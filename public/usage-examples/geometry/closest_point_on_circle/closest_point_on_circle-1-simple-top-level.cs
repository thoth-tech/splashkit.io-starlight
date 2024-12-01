using static SplashKitSDK.SplashKit;
using SplashKitSDK;

 // Prompt for x and y value 
Write("Enter x point: ");
int x = ConvertToInteger(ReadLine());
Write("Enter y point: ");
int y = ConvertToInteger(ReadLine());

Window wnd = OpenWindow("Closest point", 600, 600);
ClearScreen();

// Set circle point to center of screen and draw to screen
Point2D circle_pnt = new Point2D() {X = 300, Y = 300};
Circle circle = CircleAt(circle_pnt, 100);
DrawCircle(ColorBlack(), circle);

RefreshScreen();

// Initialize the input points as a 2D point
Point2D point = new Point2D() {X = x, Y = y};

// Get closest point to the point on circle
Point2D close_point = ClosestPointOnCircle(point, circle);

// Draw circle to indicate points
FillCircleOnWindow(wnd, ColorRed(), close_point.X, close_point.Y, 5);
FillCircleOnWindow(wnd, ColorBlue(), point.X, point.Y, 5);

RefreshScreen();

Delay(5000);

CloseAllWindows();