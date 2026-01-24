using SplashKitSDK;

new Window("Key Down Example", 800, 600);

while (!SplashKit.QuitRequested())
{
    SplashKit.ProcessEvents();
    SplashKit.ClearScreen(Color.White);

    if (SplashKit.KeyDown(KeyCode.SpaceKey))
    {
        SplashKit.DrawText("Space key is pressed", Color.Black, 200, 300);
    }
    else
    {
        SplashKit.DrawText("Press the space key", Color.Black, 200, 300);
    }

    SplashKit.RefreshScreen();
}
