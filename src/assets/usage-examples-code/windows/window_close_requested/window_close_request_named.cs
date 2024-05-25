using SplashKitSDK;

class Program
{
    static void Main()
    {
        SplashKit.OpenWindow("My Window", 800, 600);
        
        while (!SplashKit.WindowCloseRequested("My Window"))
        {
            SplashKit.ProcessEvents();
            SplashKit.ClearScreen(Color.White);
            SplashKit.DrawText("Hello, SplashKit!", Color.Black, 20, 20);
            SplashKit.RefreshScreen();
        }

        SplashKit.CloseWindow("My Window");
    }
}
