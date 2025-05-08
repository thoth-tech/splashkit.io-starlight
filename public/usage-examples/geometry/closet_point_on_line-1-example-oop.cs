using SplashKitSDK;

namespace MagneticPointExample
{
    public class MagneticPointApp
    {
        private Window _window;
        private Line _line;

        public MagneticPointApp()
        {
            _window = new Window("Magnetic Point", 600, 600);
            _line = SplashKit.LineFrom(100, 100, 500, 400);
        }

        public void Run()
        {
            while (!_window.CloseRequested)
            {
                SplashKit.ProcessEvents();

                Point2D mouse = SplashKit.MousePosition();
                Point2D closest = SplashKit.ClosestPointOnLine(mouse, _line);

                SplashKit.ClearScreen(Color.White);
                SplashKit.DrawLine(Color.Black, _line);
                SplashKit.FillCircle(Color.Blue, mouse.X, mouse.Y, 5);
                SplashKit.FillCircle(Color.Red, closest.X, closest.Y, 5);
                SplashKit.DrawLine(Color.Gray, mouse.X, mouse.Y, closest.X, closest.Y);
                SplashKit.DrawText("Mouse: " + mouse.ToString(), Color.Black, 20, 520);
                SplashKit.DrawText("Closest: " + closest.ToString(), Color.Red, 20, 540);

                SplashKit.RefreshScreen();
            }

            _window.Close();
        }
    }

    public class Program
    {
        public static void Main()
        {
            MagneticPointApp app = new MagneticPointApp();
            app.Run();
        }
    }
}

