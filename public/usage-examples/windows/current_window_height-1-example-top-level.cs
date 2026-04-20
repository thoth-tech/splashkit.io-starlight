using SplashKitSDK;
using static SplashKitSDK.SplashKit;

int randomNumber = Rnd(100, 800);

OpenWindow("Random Window Height", 275, randomNumber);

ClearScreen(ColorWhite());
DrawText($"This window is {CurrentWindowHeight()} pixels tall", ColorBlack(), 20, 20);
RefreshScreen();

Delay(5000);

CloseAllWindows();