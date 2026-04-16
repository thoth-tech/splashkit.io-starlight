using SplashKitSDK;

namespace KeyReleasedExample
{
    public class Program
    {
        public static void Main()
        {
            SplashKit.OpenWindow("Key Released", 800, 600);

            int releaseCount = 0;
            string status = "Waiting...";

            while (!SplashKit.QuitRequested())
            {
                SplashKit.ProcessEvents();

                if (SplashKit.KeyDown(KeyCode.SpaceKey))
                {
                    status = "Holding Space...";
                }

                // KeyReleased returns true only once per release event
                if (SplashKit.KeyReleased(KeyCode.SpaceKey))
                {
                    releaseCount++;
                    status = "Space released!";
                }

                SplashKit.ClearScreen(Color.White);
                SplashKit.DrawText("Press and hold [SPACE], then release it", Color.Black, "Arial", 18, 200, 220);
                SplashKit.DrawText("Status: " + status, Color.DarkGray, "Arial", 18, 200, 270);
                SplashKit.DrawText("Times released: " + releaseCount.ToString(), Color.Blue, "Arial", 24, 200, 320);
                SplashKit.RefreshScreen(60);
            }

            SplashKit.CloseAllWindows();
        }
    }
}
