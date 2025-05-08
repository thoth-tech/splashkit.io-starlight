using SplashKitSDK;
using static SplashKitSDK.SplashKit;

OpenWindow("Set Font Style", 800, 600);

Font myFont = LoadFont("MyFont", "RobotoSlab.ttf");

// Set font style to bold
SetFontStyle(myFont, FontStyle.BoldFont);
DrawText("Hello, SplashKit!", ColorBlack(), myFont, 40, 250, 270);
RefreshScreen();

Delay(5000);
CloseAllWindows();