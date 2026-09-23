using SplashKitSDK;
using static SplashKitSDK.SplashKit;

OpenWindow("Color Black", 600, 500);

ClearScreen(ColorWhite());

// Draw an 8 x 8 checkerboard
for (int row = 0; row < 8; row++)
{
    for (int col = 0; col < 8; col++)
    {
        // Fill every second square, leaving the others white
        if ((row + col) % 2 == 0)
        {
            // Function used here ↓
            FillRectangle(ColorBlack(), 100 + col * 50, 60 + row * 50, 50, 50);
        }
    }
}

// ColorBlack is also useful for drawing text on a light background
DrawText("A checkerboard drawn with ColorBlack", ColorBlack(), 175, 25);

RefreshScreen();

Delay(5000);

CloseAllWindows();
