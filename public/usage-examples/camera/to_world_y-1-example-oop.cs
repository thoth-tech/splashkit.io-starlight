using SplashKitSDK;

namespace ToWorldYExample
{
    public class Program
    {
        public static void Main()
        {
            SplashKit.OpenWindow("Depth Gauge", 800, 450);

            // The crosshair stays in the middle of the window, at this screen position
            double crosshairY = 225;

            while (!SplashKit.QuitRequested())
            {
                SplashKit.ProcessEvents();

                // The arrow keys slide the camera up and down the world
                if (SplashKit.KeyDown(KeyCode.UpKey))
                {
                    Camera.MoveBy(0, -4);
                }

                if (SplashKit.KeyDown(KeyCode.DownKey))
                {
                    Camera.MoveBy(0, 4);
                }

                SplashKit.ClearScreen(Color.White);

                // The gauge is part of the world, so it slides with the camera
                for (int tick = -1000; tick <= 3000; tick += 100)
                {
                    SplashKit.DrawLine(Color.Gray, 480, tick, 680, tick);
                    SplashKit.DrawText(tick.ToString(), Color.Black, "arial", 18, 690, tick - 10);
                }

                // The crosshair is drawn with OptionToScreen() so the camera does not move it
                SplashKit.DrawLine(Color.Red, 0, crosshairY, 800, crosshairY, SplashKit.OptionToScreen());

                // Turn the crosshair's screen position back into a position in the world
                double crosshairWorldY = SplashKit.ToWorldY(crosshairY);

                SplashKit.DrawText($"World y under the crosshair: {(int)crosshairWorldY}", Color.Black, "arial", 26, 30, 25, SplashKit.OptionToScreen());
                SplashKit.DrawText("Up and down arrows move the camera", Color.Gray, "arial", 20, 30, 410, SplashKit.OptionToScreen());

                SplashKit.RefreshScreen(60);
            }

            SplashKit.CloseAllWindows();
        }
    }
}
