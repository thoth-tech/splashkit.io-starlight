using SplashKitSDK;
using static SplashKitSDK.SplashKit;

OpenWindow("Draw Circles", 800, 600);

ClearScreen();

// Define the center of the circles
Point2D center = new Point2D { X = 400, Y = 300 };

// Create 4 circles with different radii
Circle circle1 = new Circle { Center = center, Radius = 50 };
Circle circle2 = new Circle { Center = center, Radius = 100 };
Circle circle3 = new Circle { Center = center, Radius = 150 };
Circle circle4 = new Circle { Center = center, Radius = 200 };

// Draw circles
circle1.Draw(ColorRed());
circle2.Draw(ColorBlue());
circle3.Draw(ColorOrange());
circle4.Draw(ColorGreen());

RefreshScreen();

Delay(4000);

CloseAllWindows();
