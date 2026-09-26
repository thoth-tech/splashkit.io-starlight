using SplashKitSDK;
using static SplashKitSDK.SplashKit;

OpenWindow("Screen Rectangle", 640, 480);

Rectangle screen = ScreenRectangle();

ClearScreen(ColorWhite());

FillRectangle(
    ColorLightBlue(),
    screen.X,
    screen.Y,
    screen.Width,
    screen.Height
);

DrawRectangle(
    ColorDarkBlue(),
    screen.X,
    screen.Y,
    screen.Width,
    screen.Height
);

DrawText(
    "screen_rectangle() represents the current window area",
    ColorBlack(),
    30,
    40
);

DrawText(
    "Window size: 640 x 480",
    ColorBlack(),
    30,
    75
);

RefreshScreen();

Delay(4000);

CloseAllWindows();
