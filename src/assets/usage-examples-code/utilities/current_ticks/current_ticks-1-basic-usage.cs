using System;
using SplashKitSDK;

SplashKitSDK.Timer myTimer = SplashKit.CreateTimer("My Timer");
SplashKit.StartTimer(myTimer);

// Wait for a short duration
SplashKit.Delay(1000); // Delay for 1 second (1000 milliseconds)

uint ticks = SplashKitSDK.SplashKit.CurrentTicks();

Console.WriteLine("Milliseconds since the program started: " + ticks);
