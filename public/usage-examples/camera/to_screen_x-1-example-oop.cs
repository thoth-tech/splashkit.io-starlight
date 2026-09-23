using SplashKitSDK;

namespace ToScreenXExample
{
    public class Program
    {
        public static void Main()
        {
            SplashKit.OpenWindow("Landmark Tracker", 800, 450);

            // The tower stays at this world position, wherever the camera is looking
            double towerX = 400;

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

                // Shapes are drawn in world coordinates, so they slide across the window with the camera
                SplashKit.DrawLine(Color.Gray, -2000, 350, 4000, 350);
                SplashKit.FillRectangle(Color.DarkRed, towerX - 20, 230, 40, 120);

                // Ask the camera where the tower's world position appears on the screen
                double towerScreenX = SplashKit.ToScreenX(towerX);

                // A marker at that screen position, drawn with OptionToScreen() so the camera does not move it
                SplashKit.DrawLine(Color.Blue, towerScreenX, 100, towerScreenX, 395, SplashKit.OptionToScreen());

                SplashKit.DrawText($"Tower world x: {(int)towerX}", Color.Black, "arial", 26, 30, 25, SplashKit.OptionToScreen());
                SplashKit.DrawText($"Tower screen x: {(int)towerScreenX}", Color.Black, "arial", 26, 30, 65, SplashKit.OptionToScreen());
                SplashKit.DrawText("Left and right arrows move the camera", Color.Gray, "arial", 20, 30, 410, SplashKit.OptionToScreen());

                SplashKit.RefreshScreen(60);
            }

            SplashKit.CloseAllWindows();
        }
    }
}
