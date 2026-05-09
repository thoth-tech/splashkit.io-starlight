using SplashKitSDK;

namespace TimerStarted
{
    public class Program
    {
        public static void Main()
        {
            SplashKit.OpenWindow("Timer Started", 600, 300);

            // SplashKitSDK.Timer needed to distinguish from System.Threading.Timer
            // Create a named timer - it is not started until StartTimer is called
            SplashKitSDK.Timer gameTimer = new SplashKitSDK.Timer("game_timer");

            while (!SplashKit.QuitRequested())
            {
                SplashKit.ProcessEvents();

                // Start the timer when SPACE is pressed
                if (SplashKit.KeyTyped(KeyCode.SpaceKey))
                    SplashKit.StartTimer(gameTimer);

                // Stop the timer when S is pressed
                if (SplashKit.KeyTyped(KeyCode.SKey))
                    SplashKit.StopTimer(gameTimer);

                SplashKit.ClearScreen(Color.White);

                // Use TimerStarted to check whether the timer is currently running
                bool isRunning = SplashKit.TimerStarted(gameTimer);

                // Display the timer status
                if (isRunning)
                {
                    SplashKit.DrawText("Status: Running", Color.Green, "Arial", 28, 170, 80);
                }
                else
                {
                    SplashKit.DrawText("Status: Stopped", Color.Red, "Arial", 28, 170, 80);
                }

                // Display elapsed milliseconds
                SplashKit.DrawText("Elapsed: " + SplashKit.TimerTicks(gameTimer) + " ms",
                                   Color.Black, "Arial", 20, 185, 140);

                SplashKit.DrawText("[SPACE] Start   [S] Stop", Color.Gray, "Arial", 16, 165, 220);

                SplashKit.RefreshScreen(60);
            }

            SplashKit.CloseAllWindows();
        }
    }
}
