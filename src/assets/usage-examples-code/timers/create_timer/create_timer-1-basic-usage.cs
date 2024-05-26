using SplashKitSDK;

class Program
{
    static void Main()
    {
        // Create the Timer
        SplashKitSDK.Timer myTimer = SplashKit.CreateTimer("MyTimer");

        SplashKit.StartTimer(myTimer);

        SplashKit.Delay(5000);

        double elapsedSeconds = SplashKit.TimerTicks(myTimer) / 1000.0;
        int elapsedSecondsInt = (int)elapsedSeconds;
        Console.WriteLine($"Elapsed time: {elapsedSecondsInt} seconds");

    }
}
