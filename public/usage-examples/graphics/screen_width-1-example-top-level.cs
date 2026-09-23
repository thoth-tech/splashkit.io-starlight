using SplashKitSDK;
using static SplashKitSDK.SplashKit;

OpenWindow("Screen Width", 800, 600);

int width = ScreenWidth();
string text = $"The screen is {width} pixels wide";

ClearScreen(ColorWhite());
FillRectangle(ColorBlack(), 0, ScreenHeight() / 2, width, 1);
DrawText("<", ColorBlack(), -2, ScreenHeight() / 2 - 3);
DrawText(">", ColorBlack(), width - 6, ScreenHeight() / 2 - 3);
DrawText(text, ColorBlack(), (width / 2) - (TextWidth(text, "0", 0) / 2), ScreenHeight() / 2 - 20);
RefreshScreen();

Delay(5000);

CloseAllWindows();