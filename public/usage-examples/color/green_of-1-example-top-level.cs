using SplashKitSDK;
using static SplashKitSDK.SplashKit;

OpenWindow("Green Channel Shades", 700, 450);

Color lowGreen = RGBColor(80, 30, 120);
Color mediumGreen = RGBColor(80, 130, 120);
Color highGreen = RGBColor(80, 230, 120);

ClearScreen(ColorWhite());

FillRectangle(lowGreen, 80, 70, 180, 80);
DrawText(
    "Green value: " + GreenOf(lowGreen),
    ColorBlack(),
    300,
    100
);

FillRectangle(mediumGreen, 80, 180, 180, 80);
DrawText(
    "Green value: " + GreenOf(mediumGreen),
    ColorBlack(),
    300,
    210
);

FillRectangle(highGreen, 80, 290, 180, 80);
DrawText(
    "Green value: " + GreenOf(highGreen),
    ColorBlack(),
    300,
    320
);

RefreshScreen();
Delay(5000);

CloseAllWindows();