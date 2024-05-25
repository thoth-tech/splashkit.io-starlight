using SplashKitSDK;

class Program
{
    static void Main()
    {
        Window myWindow = new Window("My Window", 800, 600);
        
        while (!SplashKit.WindowCloseRequested(myWindow))
        {
            SplashKit.ProcessEvents();
            SplashKit.ClearScreen(Color.White);
            SplashKit.DrawText("Hello, SplashKit!", Color.Black, 20, 20);
            SplashKit.RefreshScreen();
        }

        myWindow.Close();
    }
}
