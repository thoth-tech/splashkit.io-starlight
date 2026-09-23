using SplashKitSDK;

namespace MoveCameraByExample
{
    public class Program
    {
        public static void Main()
        {
            SplashKit.OpenWindow("Move Camera By Example", 800, 600);

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

                SplashKit.ClearScreen(SplashKit.ColorWhite());

                // Stationary objects in the game world
                SplashKit.FillRectangle(
                    SplashKit.ColorRed(),
                    100, 200, 100, 100
                );

                SplashKit.FillCircle(
                    SplashKit.ColorBlue(),
                    600, 300, 50
                );

                SplashKit.FillRectangle(
                    SplashKit.ColorGreen(),
                    1100, 200, 100, 100
                );

                SplashKit.FillCircle(
                    SplashKit.ColorRed(),
                    600, 800, 60
                );

                SplashKit.DrawText(
                    "Use arrow keys to move the camera",
                    SplashKit.ColorBlack(),
                    20,
                    20,
                    SplashKit.OptionToScreen()
                );

                SplashKit.RefreshScreen(60);
            }

            SplashKit.CloseAllWindows();
        }
    }
}