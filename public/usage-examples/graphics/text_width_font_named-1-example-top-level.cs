using static SplashKitSDK.SplashKit;

OpenWindow("Text Width", 680, 200);
ClearScreen(ColorWhite());

LoadFont("LOTR", "lotr.TTF");
SetFontStyle("LOTR", SplashKitSDK.FontStyle.BoldFont);
DrawText("Ringbearer", ColorBlack(), "LOTR", 100, 30, 20);

int width = TextWidth("Ringbearer", "LOTR", 100);
FillRectangle(ColorBlack(), 30, 130, width, 10);
RefreshScreen();

Delay(5000);
CloseAllWindows();