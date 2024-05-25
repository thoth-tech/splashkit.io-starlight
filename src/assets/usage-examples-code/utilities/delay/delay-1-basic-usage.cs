using System;
using SplashKitSDK;

Console.WriteLine("Start delay...");

int milliseconds = 2000; // Delay for 2000 milliseconds (2 seconds)
SplashKitSDK.SplashKit.Delay(milliseconds);

Console.WriteLine("End delay after " + milliseconds + " milliseconds.");
