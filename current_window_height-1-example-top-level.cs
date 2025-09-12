using SplashKitSDK;
using static SplashKitSDK.SplashKit;

Random rnd = new Random();

OpenWindow("Random Window Height", 275, rnd.Next(100, 800));

ClearScreen(ColorWhite());
DrawText($"This window is {CurrentWindowHeight()} pixels tall", ColorBlack(), 20, 20);
RefreshScreen();

Delay(5000);

CloseAllWindows();