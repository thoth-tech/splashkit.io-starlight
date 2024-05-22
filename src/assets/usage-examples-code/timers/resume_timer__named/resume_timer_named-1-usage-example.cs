using System;
using SplashKitSDK;

class Program
{
    static void Main(string[] args)
    {
        string timerName = "myTimer";

        SplashKit.StartTimer(timerName);

        for (int i = 4; i > 0; --i)
        {
            Console.WriteLine(i + " seconds remaining...");
            System.Threading.Thread.Sleep(1000); 
            if (i == 3)
            {
                SplashKit.PauseTimer(timerName);
                Console.WriteLine("Timer paused at 3 seconds.");
            }
        }

        // Resume the timer
        Console.WriteLine("Timer resumed...");
        SplashKit.ResumeTimer(timerName);
    }
}
