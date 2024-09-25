using static SplashKitSDK.SplashKit;

OpenWindow("Blue Background", 800, 600);

ClearScreen();
RefreshScreen(60);
Delay(1000);

ClearScreen(ColorBlue());
RefreshScreen(60);
Delay(4000);

CloseAllWindows();