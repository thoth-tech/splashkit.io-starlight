using static SplashKitSDK.SplashKit;

OpenWindow("Simple Red Triangle", 800, 600);
{
    ProcessEvents();
    ClearScreen(Color.White);
    FillTriangle(Color.Red, 150, 50, 250, 250, 50, 250);

}
