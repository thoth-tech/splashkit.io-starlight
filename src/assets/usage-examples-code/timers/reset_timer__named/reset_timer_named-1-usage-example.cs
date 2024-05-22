using System;
using SplashKitSDK;

class Program
{
    static void Main(string[] args)
    {
        string timerName = "myTimer";

        for (int i = 3; i > 0; --i)
        {
            Console.WriteLine(i + " seconds remaining...");
            System.Threading.Thread.Sleep(1000); 
        }
        // Reset the timer
        SplashKit.ResetTimer(timerName);

        Console.WriteLine("Resetting timer: " + timerName);
    }
}
