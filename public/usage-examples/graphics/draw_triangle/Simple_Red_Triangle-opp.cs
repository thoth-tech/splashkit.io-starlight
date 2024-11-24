using SplashKitSDK;
public class SimpleRedTriangle
{
    public static void Main()
    {
        new SimpleRedTriangle().Run();
    }
    public void Run()
    {
        Window _window = new Window("Simple Red Triangle", 800, 600);

        while (!_window.CloseRequested)
        {
            SplashKit.ProcessEvents();
            _window.Clear(Color.White);
            SplashKit.FillTriangle(Color.Red, 150, 50, 250, 250, 50, 250);
            _window.Refresh();
        }
    }
    
}

