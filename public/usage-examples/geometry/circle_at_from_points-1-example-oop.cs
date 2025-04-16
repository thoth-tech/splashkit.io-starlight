using SplashKitSDK;

public class Program
{
    public static void Main()
    {
        Window window = new Window("Circle At Example", 800, 600);

        Circle circle = SplashKit.CircleAt(400, 300, 100);

        while (!window.CloseRequested)
        {
            SplashKit.ProcessEvents();
            window.Clear(Color.White);
            SplashKit.FillCircle(Color.Blue, circle);
            window.Refresh();

            SplashKit.Delay(8000);
        }
    }
}
