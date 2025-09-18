using SplashKitSDK;

class App
{
    public void Run()
    {
        SplashKit.OpenWindow("color slider demo", 800, 400);

        Color current = Color.SkyBlue;
        Rectangle panel = SplashKit.RectangleFrom(40, 40, 300, 140);

        while (!SplashKit.QuitRequested())
        {
            SplashKit.ProcessEvents();
            SplashKit.ClearScreen(Color.White);

            current = SplashKit.ColorSlider(current, panel);
            SplashKit.FillRectangle(current, 400, 40, 320, 140);

            SplashKit.DrawInterface();
            SplashKit.RefreshScreen();
        }

        SplashKit.CloseAllWindows();
    }
}

class Program
{
    static void Main()
    {
        new App().Run();
    }
}
