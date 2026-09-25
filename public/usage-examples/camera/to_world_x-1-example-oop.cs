using SplashKitSDK;

namespace ToWorldXExample
{
    public class Program
    {
        public static void Main()
        {
            SplashKit.OpenWindow("Crosshair Ruler", 800, 450);

            // The crosshair stays in the middle of the window, at this screen position
            double crosshairX = 400;

            while (!SplashKit.QuitRequested())
            {
                SplashKit.ProcessEvents();

                // The arrow keys slide the camera along the world
                if (SplashKit.KeyDown(KeyCode.LeftKey))
                {
                    Camera.MoveBy(-4, 0);
                }

                if (SplashKit.KeyDown(KeyCode.RightKey))
                {
                    Camera.MoveBy(4, 0);
                }

                SplashKit.ClearScreen(Color.White);

                // The ruler is part of the world, so it slides with the camera
                for (int tick = -1000; tick <= 3000; tick += 100)
                {
                    SplashKit.DrawLine(Color.Gray, tick, 150, tick, 300);
                    SplashKit.DrawText(tick.ToString(), Color.Black, "arial", 18, tick + 5, 305);
                }

                // The crosshair is drawn with OptionToScreen() so the camera does not move it
                SplashKit.DrawLine(Color.Red, crosshairX, 70, crosshairX, 395, SplashKit.OptionToScreen());

                // Turn the crosshair's screen position back into a position in the world
                double crosshairWorldX = SplashKit.ToWorldX(crosshairX);

                SplashKit.DrawText($"World x under the crosshair: {(int)crosshairWorldX}", Color.Black, "arial", 26, 30, 25, SplashKit.OptionToScreen());
                SplashKit.DrawText("Left and right arrows move the camera", Color.Gray, "arial", 20, 30, 410, SplashKit.OptionToScreen());

                SplashKit.RefreshScreen(60);
            }

            SplashKit.CloseAllWindows();
        }
    }
}
