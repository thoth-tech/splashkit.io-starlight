using SplashKitSDK;

new Window("Font Example", 800, 600);
SplashKit.LoadFont("myFont", "arial.ttf");

while (!SplashKit.QuitRequested())
{
    SplashKit.ProcessEvents();
    SplashKit.ClearScreen(Color.White);

    SplashKit.DrawText("Hello with Font!", Color.Black, "myFont", 20, 200, 250);

    SplashKit.RefreshScreen();
}