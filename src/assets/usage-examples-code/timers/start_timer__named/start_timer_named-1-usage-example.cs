using SplashKitSDK;

class Program
{
    static void Main()
    {
        SplashKitSDK.Timer myTimer = SplashKit.CreateTimer("MyTimer");

        // Start the timer
        SplashKit.StartTimer(myTimer);

        SplashKit.Delay(5000);

        double elapsedSeconds = SplashKit.TimerTicks(myTimer) / 1000.0;
        int elapsedSecondsInt = (int)elapsedSeconds;
        Console.WriteLine($"Elapsed time: {elapsedSecondsInt} seconds");

    }
}
