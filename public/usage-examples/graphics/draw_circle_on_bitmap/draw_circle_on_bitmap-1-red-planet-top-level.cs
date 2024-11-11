using SplashKitSDK;
using static SplashKitSDK.SplashKit;

// Create a bitmap to draw on
Bitmap planet = CreateBitmap("planet", 400, 400);

// Fill background with dark color
ClearBitmap(planet, ColorBlack());

// Create color
Color red = ColorRed();

// Draw the main planet circle
FillCircleOnBitmap(planet, RGBAColor(180, 0, 0, 255), 200, 200, 150);
SplashKit.DrawCircleOnBitmap(planet, red, 200, 200, 150);

// Add some surface details with smaller circles
for (int i = 0; i < 15; i++)
{
    double x = Rnd(100, 300);  // Random between 100 and 300
    double y = Rnd(100, 300);   // Random between 100 and 300
    double size = Rnd(10, 30);  // Random between 10 and 30
    SplashKit.DrawCircleOnBitmap(planet, red, x, y, size);
}

// Save and free the bitmap
SaveBitmap(planet, "draw_circle_on_bitmap-1-red-planet");
FreeBitmap(planet);