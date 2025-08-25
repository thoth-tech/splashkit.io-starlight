using SplashKitSDK;
using static SplashKitSDK.SplashKit;

OpenWindow("Screen Height", 800, 600);

int height = ScreenHeight();
string text = $"The screen is {height} pixels tall";

ClearScreen(ColorWhite());
FillRectangle(ColorBlack(), ScreenWidth() / 2, 0, 1, height);
DrawText("^", ColorBlack(), ScreenWidth() / 2 - 3, 0);
DrawText("V", ColorBlack(), ScreenWidth() / 2 - 3, height - 8);
DrawText(text, ColorBlack(), ScreenWidth() / 2 + 20, ScreenHeight() / 2);
RefreshScreen();

Delay(5000);

CloseAllWindows();