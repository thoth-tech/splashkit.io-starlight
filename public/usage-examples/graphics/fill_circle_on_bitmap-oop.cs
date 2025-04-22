using SplashKitSDK;

public class SurfaceDrawer
{
    private Window _window;
    private Bitmap _surface;

    public SurfaceDrawer()
    {
        _window = new Window("OOP Circle Drawer", 400, 400);
        _surface = new Bitmap("surface", 400, 400);
        _surface.Clear(Color.Black);
    }

    public void DrawBase()
    {
        Color mainColor = SplashKit.RGBAColor(180, 0, 0, 255);
        _surface.FillCircle(mainColor, 200, 200, 150);
        _surface.DrawCircle(Color.Red, 200, 200, 150);
    }

    public void AddDetail()
    {
        for (int i = 0; i < 15; i++)
        {
            float x = SplashKit.Rnd(100, 300);
            float y = SplashKit.Rnd(100, 300);
            float radius = SplashKit.Rnd(10, 30);
            _surface.DrawCircle(Color.Red, x, y, radius);
        }
    }

    public void Run()
    {
        while (!_window.CloseRequested)
        {
            SplashKit.ProcessEvents();
            _window.Draw(_surface, 0, 0);
            SplashKit.RefreshScreen();
        }
    }
}

public class Program
{
    public static void Main()
    {
        SurfaceDrawer drawer = new SurfaceDrawer();
        drawer.DrawBase();
        drawer.AddDetail();
        drawer.Run();
    }
}
