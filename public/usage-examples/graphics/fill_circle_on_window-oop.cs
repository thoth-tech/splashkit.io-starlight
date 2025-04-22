using SplashKitSDK;

public class TrafficLightApp
{
    private Window _window;

    public TrafficLightApp()
    {
        _window = new Window("Traffic Lights - OOP", 800, 600);
    }

    public void DrawTrafficLights()
    {
        _window.Clear(Color.White);

        _window.FillCircle(Color.Red, 400, 100, 50);
        _window.FillCircle(Color.Yellow, 400, 250, 50);
        _window.FillCircle(Color.Green, 400, 400, 50);

        _window.Refresh();
    }

    public void Run()
    {
        DrawTrafficLights();
        SplashKit.Delay(5000);
        _window.Close();
    }

    public static void Main()
    {
        TrafficLightApp app = new TrafficLightApp();
        app.Run();
    }
}
