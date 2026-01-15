using SplashKitSDK;

// open window
SplashKit.OpenWindow("color slider demo", 800, 400);

// start color + panel for sliders
Color current = Color.SkyBlue;
Rectangle panel = SplashKit.RectangleFrom(40, 40, 300, 140);

while (!SplashKit.QuitRequested())
{
    SplashKit.ProcessEvents();
    SplashKit.ClearScreen(Color.White);

    // update color using sliders
    current = SplashKit.ColorSlider(current, panel);

    // preview rectangle
    SplashKit.FillRectangle(current, 400, 40, 320, 140);

    SplashKit.DrawInterface();
    SplashKit.RefreshScreen();
}

SplashKit.CloseAllWindows();
