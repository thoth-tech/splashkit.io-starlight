using static SplashKitSDK.SplashKit;
using SplashKitSDK;

// Open the window
OpenWindow("Bitmap Collisions", 315, 330);

// Load the bitmap and set its position
Bitmap skBmp = LoadBitmap("skbox", "skbox.png");
Point2D bmpLoc = new Point2D() { X = 50, Y = 50 };

// Define the circles and their positions
Circle blackCircle = new Circle()
{
    Center = new Point2D() { X = 20, Y = 20 },
    Radius = 20
};

Circle redCircle = new Circle()
{
    Center = new Point2D() { X = 150, Y = 150 },
    Radius = 20
};

// Clear the screen and draw the elements
ClearScreen(RGBColor(67, 80, 175));
DrawBitmap(skBmp, bmpLoc.X, bmpLoc.Y);
DrawCircle(ColorBlack(), blackCircle);
DrawCircle(ColorRed(), redCircle);

// Check for collisions and display messages
if (BitmapCircleCollision(skBmp, bmpLoc, blackCircle))
{
    WriteLine("Black Circle Collision!");
}

if (BitmapCircleCollision(skBmp, bmpLoc, redCircle))
{
    WriteLine("Red Circle Collision!");
}

// Refresh the screen, wait, and close the window
RefreshScreen();
Delay(4000);
CloseAllWindows();
