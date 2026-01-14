using SplashKitSDK;
using static SplashKitSDK.SplashKit;

OpenWindow("Text Height", 800, 600);

Font textFont = FontNamed("Century.ttf");
string textString = "Example text";
//Change the below value to affect the text's height
int textFontSize = 100;
int height = TextHeight(textString, textFont, textFontSize);
Line l = LineFrom(30, 200, 30, 200 + height);

ClearScreen(ColorWhite());
DrawText(textString, ColorBlack(), textFont, textFontSize, 50, 200);
DrawLine(ColorBlack(), l);
FillTriangle(ColorBlack(), l.StartPoint.X, l.StartPoint.Y, l.StartPoint.X - 7, l.StartPoint.Y + 7, l.StartPoint.X + 7, l.StartPoint.Y + 7);
FillTriangle(ColorBlack(), l.EndPoint.X, l.EndPoint.Y, l.EndPoint.X + 7, l.EndPoint.Y - 7, l.EndPoint.X - 7, l.EndPoint.Y - 7);
DrawText($"This text is {height} pixels tall", ColorBlack(), 30, 220 + height);
RefreshScreen();

Delay(5000);

CloseAllWindows();