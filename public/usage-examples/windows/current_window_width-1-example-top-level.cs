using SplashKitSDK;
using static SplashKitSDK.SplashKit;

OpenWindow("Current Window Width", 800, 600);

while (!QuitRequested())
{
    ProcessEvents();

    int windowWidth = CurrentWindowWidth();

    ClearScreen(ColorWhite());

    DrawText("Current window width:", ColorBlack(), 220, 220);
    DrawText(windowWidth.ToString() + " pixels", ColorBlue(), 260, 270);

    RefreshScreen(60);
}

CloseAllWindows();