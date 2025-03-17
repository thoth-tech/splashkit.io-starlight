using static SplashKitSDK.SplashKit;

OpenWindow("Text_Height", 680, 200);
ClearScreen(ColorWhite());

LoadFont("LOTR", "lotr.TTF");
SetFontStyle("LOTR", SplashKitSDK.FontStyle.BoldFont);
DrawText("Ringbearer", ColorBlack(), "LOTR", 100, 30, 20);

int height = TextHeight("Ringbearer", "LOTR", 100);
FillRectangle(ColorBlack(), 20, 20, 10, height);
RefreshScreen();

Delay(5000);
CloseAllWindows();