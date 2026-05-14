using SplashKitSDK;

Window wind = SplashKit.OpenWindow("Simple Welcome Screen", 800, 600);

while (!SplashKit.QuitRequested())
{
    SplashKit.ProcessEvents();

    SplashKit.ClearWindow(wind, Color.SkyBlue);
    SplashKit.FillRectangle(Color.White, 220, 230, 360, 120);
    SplashKit.DrawText("Welcome to SplashKit!", Color.Black, 290, 270);
    SplashKit.DrawText("This window was opened using OpenWindow.", Color.Black, 245, 305);

    SplashKit.RefreshWindow(wind);
}

SplashKit.CloseAllWindows();