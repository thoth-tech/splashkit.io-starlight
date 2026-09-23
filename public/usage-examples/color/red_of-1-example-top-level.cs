using SplashKitSDK;
using static SplashKitSDK.SplashKit;

OpenWindow("Red Channel Shades", 700, 450);

Color lowRed = RGBColor(30, 80, 120);
Color mediumRed = RGBColor(130, 80, 120);
Color highRed = RGBColor(230, 80, 120);

ClearScreen(ColorWhite());

FillRectangle(lowRed, 80, 70, 180, 80);
DrawText(
    "Red value: " + RedOf(lowRed),
    ColorBlack(),
    300,
    100
);

FillRectangle(mediumRed, 80, 180, 180, 80);
DrawText(
    "Red value: " + RedOf(mediumRed),
    ColorBlack(),
    300,
    210
);

FillRectangle(highRed, 80, 290, 180, 80);
DrawText(
    "Red value: " + RedOf(highRed),
    ColorBlack(),
    300,
    320
);

RefreshScreen();
Delay(5000);

CloseAllWindows();