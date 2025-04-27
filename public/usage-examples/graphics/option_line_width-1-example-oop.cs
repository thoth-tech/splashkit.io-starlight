using SplashKitSDK;

public class Program
{
    public static void Main()
    {
        Window window = SplashKit.OpenWindow("Line Width Example", 800, 600);

        window.Show();

        DrawingOptions opt = SplashKit.OptionLineWidth(10);
        SplashKit.DrawLine(Color.Black, 100, 100, 200, 200, opt);

        opt = SplashKit.OptionLineWidth(5);  // Reuse opt variable
        SplashKit.DrawLine(Color.Red, 400, 100, 600, 250, opt);

        SplashKit.RefreshScreen();

        while (!SplashKit.WindowCloseRequested(window))
        {
            SplashKit.ProcessEvents();
        }
    }
}
