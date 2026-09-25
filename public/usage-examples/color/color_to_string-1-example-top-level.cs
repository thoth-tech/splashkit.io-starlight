using SplashKitSDK;
using static SplashKitSDK.SplashKit;

OpenWindow("Color To String", 800, 450);

Color[] colors = { ColorRed(), ColorGreen(), ColorBlue(), ColorOrange(), ColorPurple() };
string[] labels = { "Red", "Green", "Blue", "Orange", "Purple" };
int rectWidth = 120;
int rectHeight = 200;
int startX = 60;
int startY = 130;
int gap = 20;

ClearScreen(ColorWhite());

DrawText("Color To String", ColorBlack(), 315, 50);
DrawText("Each colour displayed with its hex string value", ColorBlack(), 220, 75);

for (int i = 0; i < 5; i++)
{
    int x = startX + i * (rectWidth + gap);

    FillRectangle(colors[i], x, startY, rectWidth, rectHeight);

    // Function used here ↓
    string hex = ColorToString(colors[i]);
    DrawText(labels[i], ColorBlack(), x + 30, startY + rectHeight + 10);
    DrawText(hex, ColorBlack(), x + 5, startY + rectHeight + 28);
}

RefreshScreen();
Delay(5000);

CloseAllWindows();
