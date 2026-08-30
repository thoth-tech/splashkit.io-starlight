using SplashKitSDK;
using static SplashKitSDK.SplashKit;

OpenWindow("Color Blue Violet", 500, 500);

ClearScreen(ColorWhite());

// Draw 8 circles from largest to smallest to create a set of rings
for (int i = 0; i < 8; i++)
{
    double radius = 200 - i * 25;

    if (i % 2 == 0)
    {
        // Function used here ↓
        FillCircle(ColorBlueViolet(), 250, 250, radius);
    }
    else
    {
        // The white circles cut the rings out of the blue violet ones
        FillCircle(ColorWhite(), 250, 250, radius);
    }
}

DrawText("Rings drawn with ColorBlueViolet", ColorBlueViolet(), 155, 470);

RefreshScreen();

Delay(5000);

CloseAllWindows();
