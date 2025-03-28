using static SplashKitSDK.SplashKit;

OpenWindow("Text Height", 680, 200);
ClearScreen(ColorWhite());

LoadFont("LOTR", "lotr.TTF");
SetFontStyle("LOTR", SplashKitSDK.FontStyle.BoldFont);
DrawText("Ringbearer", ColorBlack(), "LOTR", 100, 30, 20);

//Getting the height of the text to fill a rectange of that height
int height = TextHeight("Ringbearer", "LOTR", 100);
FillRectangle(ColorBlack(), 20, 20, 10, height);
RefreshScreen();

Delay(5000);
CloseAllWindows();