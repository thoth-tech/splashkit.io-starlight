using static SplashKitSDK.SplashKit;

OpenWindow("Key Down Example", 400, 200);

WriteLine("Press and hold Space...");

while (!QuitRequested())
{
    ProcessEvents();

    if (KeyDown(KeyCode.SpaceKey))
    {
        WriteLine("Space key is held down!");
        Delay(500);
    }
}

CloseAllWindows();