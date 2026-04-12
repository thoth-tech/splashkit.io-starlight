using SplashKitSDK;

class Program
{
    static void Main(string[] args)
    {
        // Create and start a timer
        SplashKitSDK.Timer myTimer = SplashKit.CreateTimer("my_timer");
        SplashKit.StartTimer(myTimer);
        SplashKit.WriteLine("Timer started!");

        // Wait 1 second
        SplashKit.Delay(1000);
        SplashKit.WriteLine("After 1 second: " + SplashKit.TimerTicks(myTimer) + " ms");

        // Pause the timer
        SplashKit.PauseTimer(myTimer);
        SplashKit.WriteLine("Timer paused!");

        // Wait 1 second while paused - timer should NOT increase
        SplashKit.Delay(1000);
        SplashKit.WriteLine("After pause delay, still at: " + SplashKit.TimerTicks(myTimer) + " ms");

        // Resume the timer
        SplashKit.ResumeTimer(myTimer);
        SplashKit.WriteLine("Timer resumed!");

        // Wait 1 more second - timer continues from where it left off
        SplashKit.Delay(1000);
        SplashKit.WriteLine("After resume: " + SplashKit.TimerTicks(myTimer) + " ms");

        SplashKit.FreeTimer(myTimer);
    }
}