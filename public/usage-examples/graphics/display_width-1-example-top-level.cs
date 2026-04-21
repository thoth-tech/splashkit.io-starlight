using SplashKitSDK;
using static SplashKitSDK.SplashKit;

Display display = DisplayDetails(0);
int width = DisplayWidth(display);

OpenWindow("How Wide is Your Screen?", width, 250);

Font font = FontNamed("Century.ttf");
string text = $"The display is {width} pixels wide";

ClearScreen(ColorWhite());
FillRectangle(ColorBlack(), 0, ScreenHeight() / 2, width, 1);
DrawText("<", ColorBlack(), -2, ScreenHeight() / 2 - 3);
DrawText(">", ColorBlack(), width - 6, ScreenHeight() / 2 - 3);
DrawText(text, ColorBlack(), font, 30, (ScreenWidth() / 2) - (TextWidth(text, font, 30) / 2), ScreenHeight() / 2 - 60);
RefreshScreen();

Delay(5000);

CloseAllWindows();