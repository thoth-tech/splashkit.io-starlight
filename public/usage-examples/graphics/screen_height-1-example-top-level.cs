using SplashKitSDK;
using static SplashKitSDK.SplashKit;

OpenWindow("Screen Height", 800, 600);

int height = ScreenHeight();
Line l = LineFrom(ScreenWidth() / 2, 0, ScreenWidth() / 2, height);
string text = $"The screen is {height} pixels tall";

ClearScreen(ColorWhite());
DrawLine(ColorBlack(), l);
FillTriangle(ColorBlack(), l.StartPoint.X, l.StartPoint.Y, l.StartPoint.X - 10, l.StartPoint.Y + 10, l.StartPoint.X + 10, l.StartPoint.Y + 10);
FillTriangle(ColorBlack(), l.EndPoint.X, l.EndPoint.Y, l.EndPoint.X + 10, l.EndPoint.Y - 10, l.EndPoint.X - 10, l.EndPoint.Y - 10);
DrawText(text, ColorBlack(), ScreenWidth() / 2 + 20, ScreenHeight() / 2);
RefreshScreen();

Delay(5000);

CloseAllWindows();