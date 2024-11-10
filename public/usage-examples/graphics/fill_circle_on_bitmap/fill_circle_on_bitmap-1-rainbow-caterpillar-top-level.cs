using static SplashKitSDK.SplashKit;

// Create a bitmap for our caterpillar
Bitmap bitmap = CreateBitmap("caterpillar", 400, 200);

// Fill background with light color
ClearBitmap(bitmap, ColorWhite());

// Create rainbow colors array
Color[] colors = { ColorRed(), ColorOrange(), ColorYellow(), 
                  ColorGreen(), ColorBlue(), ColorViolet() };

// Draw circles for caterpillar segments with alternating y positions
double x = 50;
for(int i = 0; i < colors.Length; i++)
{
    double y = 100 + (i % 2 == 0 ? 20 : -20);  // Alternate up and down
    FillCircleOnBitmap(bitmap, colors[i], x, y, 40);
    x += 60;
}

// Draw eyes (adjusted to match first segment position)
FillCircleOnBitmap(bitmap, ColorBlack(), 60, 100, 8);
FillCircleOnBitmap(bitmap, ColorBlack(), 60, 130, 8);

// Save and free the bitmap
SaveBitmap(bitmap, "rainbow_caterpillar");
FreeBitmap(bitmap);