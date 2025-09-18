using SplashKitSDK;
using static SplashKitSDK.SplashKit;

int randomNumber = Rnd(275, 800);

OpenWindow("Random Window Width", randomNumber, 100);

ClearScreen(ColorWhite());
DrawText($"This window is {CurrentWindowWidth()} pixels wide", ColorBlack(), 20, 20);
RefreshScreen();

Delay(5000);

CloseAllWindows();