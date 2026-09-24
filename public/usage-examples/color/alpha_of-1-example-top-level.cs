using SplashKitSDK;
using static SplashKitSDK.SplashKit;

OpenWindow("Alpha Of", 800, 450);

int[] alphas = { 50, 100, 150, 200, 255 };
int rectWidth = 120;
int rectHeight = 200;
int startX = 60;
int startY = 140;
int gap = 20;

ClearScreen(ColorWhite());

// Draw a background stripe so transparency is visible
FillRectangle(ColorLightBlue(), 0, startY, 800, rectHeight);

DrawText("Transparency Layers", ColorBlack(), 300, 55);
DrawText("Same colour at different alpha values (light blue shows through)", ColorBlack(), 155, 80);

for (int i = 0; i < 5; i++)
{
    Color c = RgbaColor(200, 50, 50, alphas[i]);
    int x = startX + i * (rectWidth + gap);

    FillRectangle(c, x, startY, rectWidth, rectHeight);

    // Function used here ↓
    int a = AlphaOf(c);
    DrawText("Alpha: " + a, ColorBlack(), x + 22, startY + rectHeight + 12);
}

RefreshScreen();
Delay(5000);

CloseAllWindows();
