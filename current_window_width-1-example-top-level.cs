using SplashKitSDK;
using static SplashKitSDK.SplashKit;

Random rnd = new Random();

OpenWindow("Random Window Width", rnd.Next(275, 800), 100);

ClearScreen(ColorWhite());
DrawText($"This window is {CurrentWindowWidth()} pixels wide", ColorBlack(), 20, 20);
RefreshScreen();

Delay(5000);

CloseAllWindows();