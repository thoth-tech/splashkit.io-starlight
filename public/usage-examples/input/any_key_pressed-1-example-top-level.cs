using SplashKitSDK;
using static SplashKitSDK.SplashKit;

OpenWindow("Any Key Pressed", 800, 600);

string message = "No key is being pressed.";
Color circleColor = ColorRed();

while (!QuitRequested())
{
    ProcessEvents();

    if (AnyKeyPressed())
    {
        message = "A key is being pressed.";
        circleColor = ColorGreen();
    }
    else
    {
        message = "No key is being pressed.";
        circleColor = ColorRed();
    }

    ClearScreen(ColorWhite());

    FillCircle(circleColor, 400, 250, 80);
    DrawText(message, ColorBlack(), 240, 400);

    RefreshScreen(60);
}

CloseAllWindows();