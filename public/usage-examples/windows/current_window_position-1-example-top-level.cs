using SplashKitSDK;
using static SplashKitSDK.SplashKit;

OpenWindow("Live Window Position Monitor", 700, 250);

while (!QuitRequested())
{
    ProcessEvents();

    Point2D pos = CurrentWindowPosition();
    int x = CurrentWindowX();
    int y = CurrentWindowY();

    ClearScreen(ColorWhite());

    DrawText("Move the window to see the values update", ColorBlack(), 20, 20);
    DrawText($"Current Window Position: ({(int)pos.X}, {(int)pos.Y})", ColorBlue(), 20, 70);
    DrawText($"Current Window X: {x}", ColorRed(), 20, 110);
    DrawText($"Current Window Y: {y}", ColorGreen(), 20, 150);

    RefreshScreen(60);
}

CloseAllWindows();