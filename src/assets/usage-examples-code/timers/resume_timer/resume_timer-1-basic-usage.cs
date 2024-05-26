using Timer = SplashKitSDK.Timer;
using System;

class Program
{
    static void Main(string[] args)
    {
        Timer myTimer = new Timer("my_timer");
        myTimer.Start();
        Console.WriteLine("Timer started");
        myTimer.Pause();
        Console.WriteLine("Timer paused");

        // Resume the paused timer 
        SplashKitSDK.SplashKit.ResumeTimer(myTimer);
        Console.WriteLine("Timer resumed");
    }
}
