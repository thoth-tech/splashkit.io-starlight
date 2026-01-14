using SplashKitSDK;
using static SplashKitSDK.SplashKit;

OpenWindow("Font Load Example", 800, 600);

// Import font and draw text
Font myFont = LoadFont("MyFont", "RobotoSlab.ttf");
DrawText("Hello, SplashKit!", ColorBlack(), myFont, 40, 250, 270);
RefreshScreen();

Delay(5000);
CloseAllWindows();