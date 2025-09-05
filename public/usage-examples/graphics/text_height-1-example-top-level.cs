using SplashKitSDK;
using static SplashKitSDK.SplashKit;

OpenWindow("Text Height", 800, 600);

Font text_font = FontNamed("Century.ttf");
string text_string = "Example text";
//Change the below value to affect the text's height
int text_font_size = 100;
//Function used here ↓
int height = TextHeight(text_string, text_font, text_font_size);
Line l = LineFrom(30, 200, 30, 200 + height);

ClearScreen(Color.White);
DrawText(text_string, Color.Black, text_font, text_font_size, 50, 200);
DrawLine(Color.Black, l);
FillTriangle(Color.Black, l.StartPoint.X, l.StartPoint.Y, l.StartPoint.X - 7, l.StartPoint.Y + 7, l.StartPoint.X + 7, l.StartPoint.Y + 7);
FillTriangle(Color.Black, l.EndPoint.X, l.EndPoint.Y, l.EndPoint.X + 7, l.EndPoint.Y - 7, l.EndPoint.X - 7, l.EndPoint.Y - 7);
DrawText($"This text is {height} pixels tall", Color.Black, 30, 220 + height);
RefreshScreen();

Delay(5000);

CloseAllWindows();