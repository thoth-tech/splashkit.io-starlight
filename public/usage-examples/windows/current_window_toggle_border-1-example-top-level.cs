using SplashKitSDK;
using static SplashKitSDK.SplashKit;

OpenWindow("Press B to Toggle Border", 700, 250);

while (!QuitRequested())
{
    ProcessEvents();

    if (KeyTyped(KeyCode.BKey))
    {
        CurrentWindowToggleBorder();
    }

    string borderState = CurrentWindowHasBorder() ? "On" : "Off";

    ClearScreen(ColorWhite());

    DrawText("Press B to toggle border", ColorBlack(), 20, 20);
    DrawText($"Border: {borderState}", ColorBlue(), 20, 80);

    RefreshScreen(60);
}

CloseAllWindows();