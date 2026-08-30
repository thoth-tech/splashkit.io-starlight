using SplashKitSDK;
using static SplashKitSDK.SplashKit;

OpenWindow("Color Blue", 600, 400);

// The height of each bar in the chart
int[] barHeights = { 120, 200, 90, 260, 160 };

ClearScreen(ColorWhite());

for (int i = 0; i < 5; i++)
{
    int height = barHeights[i];

    // Bars are drawn upwards from the base line at y = 340
    // Function used here ↓
    FillRectangle(ColorBlue(), 80 + i * 100, 340 - height, 60, height);
}

// Draw the base line of the chart
DrawLine(ColorBlack(), 50, 340, 550, 340);

DrawText("Bars filled with ColorBlue", ColorBlack(), 215, 360);

RefreshScreen();

Delay(5000);

CloseAllWindows();
