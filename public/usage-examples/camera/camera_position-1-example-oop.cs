using SplashKitSDK;

namespace CameraPositionExample
{
    public class Program
    {
        public static void Main()
        {
            SplashKit.OpenWindow("Camera Position Example", 800, 600);

            while (!SplashKit.QuitRequested())
            {
                SplashKit.ProcessEvents();

                // Move the camera using the arrow keys
                if (SplashKit.KeyDown(KeyCode.LeftKey))
                    SplashKit.MoveCameraBy(-5, 0);

                if (SplashKit.KeyDown(KeyCode.RightKey))
                    SplashKit.MoveCameraBy(5, 0);

                if (SplashKit.KeyDown(KeyCode.UpKey))
                    SplashKit.MoveCameraBy(0, -5);

                if (SplashKit.KeyDown(KeyCode.DownKey))
                    SplashKit.MoveCameraBy(0, 5);

                Point2D camera = SplashKit.CameraPosition();

                SplashKit.ClearScreen(SplashKit.ColorWhite());

                // Stationary objects in the world
                SplashKit.FillRectangle(
                    SplashKit.ColorRed(),
                    100,
                    200,
                    100,
                    100
                );

                SplashKit.FillCircle(
                    SplashKit.ColorBlue(),
                    600,
                    300,
                    50
                );

                SplashKit.FillRectangle(
                    SplashKit.ColorGreen(),
                    1100,
                    200,
                    100,
                    100
                );

                SplashKit.DrawText(
                    "Use arrow keys to move the camera",
                    SplashKit.ColorBlack(),
                    20,
                    20,
                    SplashKit.OptionToScreen()
                );

                SplashKit.DrawText(
                    "Camera Position: " + SplashKit.PointToString(camera),
                    SplashKit.ColorBlack(),
                    20,
                    50,
                    SplashKit.OptionToScreen()
                );

                SplashKit.RefreshScreen(60);
            }

            SplashKit.CloseAllWindows();
        }
    }
}