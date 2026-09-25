using SplashKitSDK;

namespace CreateTimerExample
{
    public class Program
    {
        public static void Main()
        {
            SplashKit.OpenWindow("Simple Timer Display", 800, 600);

            SplashKitSDK.Timer timer = SplashKit.CreateTimer("Example Timer");
            SplashKit.StartTimer(timer);

            while (!SplashKit.QuitRequested())
            {
                SplashKit.ProcessEvents();

                double elapsedSeconds = SplashKit.TimerTicks(timer) / 1000.0;

                SplashKit.ClearScreen(Color.White);

                SplashKit.DrawText("Timer created and running", Color.Black, 20, 20);
                SplashKit.DrawText("Elapsed time: " + elapsedSeconds.ToString("0.0") + " seconds", Color.Black, 20, 60);
                SplashKit.DrawText("Close the window to finish.", Color.Black, 20, 100);

                SplashKit.RefreshScreen(60);
            }

            SplashKit.FreeTimer(timer);
        }
    }
}