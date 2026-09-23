using SplashKitSDK;

namespace ToScreenYExample
{
    public class Program
    {
        public static void Main()
        {
            SplashKit.OpenWindow("Balloon Height", 800, 450);

            // The balloon stays at this world position, wherever the camera is looking
            double balloonX = 600;
            double balloonY = 225;

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

                // Shapes are drawn in world coordinates, so they slide across the window with the camera
                SplashKit.DrawLine(Color.Gray, 400, 420, 800, 420);
                SplashKit.DrawLine(Color.Gray, balloonX, balloonY + 40, balloonX, 420);
                SplashKit.FillCircle(Color.Red, balloonX, balloonY, 40);

                // Ask the camera where the balloon's world position appears on the screen
                double balloonScreenY = SplashKit.ToScreenY(balloonY);

                // A marker at that screen position, drawn with OptionToScreen() so the camera does not move it
                SplashKit.DrawLine(Color.Blue, 380, balloonScreenY, 800, balloonScreenY, SplashKit.OptionToScreen());

                SplashKit.DrawText($"Balloon world y: {(int)balloonY}", Color.Black, "arial", 26, 30, 25, SplashKit.OptionToScreen());
                SplashKit.DrawText($"Balloon screen y: {(int)balloonScreenY}", Color.Black, "arial", 26, 30, 65, SplashKit.OptionToScreen());
                SplashKit.DrawText("Up and down arrows move the camera", Color.Gray, "arial", 20, 30, 410, SplashKit.OptionToScreen());

                SplashKit.RefreshScreen(60);
            }

            SplashKit.CloseAllWindows();
        }
    }
}
