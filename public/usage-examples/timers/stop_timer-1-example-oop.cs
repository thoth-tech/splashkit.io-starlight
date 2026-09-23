using SplashKitSDK;

namespace StopTimerExample
{
    public class Program
    {
        public static void Main()
        {
            SplashKit.OpenWindow("Press S to Stop Timer", 700, 220);

            SplashKit.CreateTimer("demo");
            SplashKit.StartTimer("demo");

            while (!SplashKit.QuitRequested())
            {
                SplashKit.ProcessEvents();

                if (SplashKit.KeyTyped(KeyCode.SKey) && SplashKit.TimerStarted("demo"))
                {
                    SplashKit.StopTimer("demo");
                }

                string status = SplashKit.TimerStarted("demo") ? "Running" : "Stopped";
                uint ticks = SplashKit.TimerTicks("demo");

                SplashKit.ClearScreen(Color.White);

                SplashKit.DrawText("Press S to stop the timer", Color.Black, 20, 20);
                SplashKit.DrawText("Status: " + status, Color.Blue, 20, 70);
                SplashKit.DrawText("Ticks: " + ticks, Color.Red, 20, 110);

                SplashKit.RefreshScreen(60);
            }

            SplashKit.CloseAllWindows();
        }
    }
}