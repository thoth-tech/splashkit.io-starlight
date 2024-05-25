using System;
using SplashKitSDK;

Window wind1 = SplashKit.OpenWindow("Window 1", 800, 600);
Window wind2 = SplashKit.OpenWindow("Window 2", 800, 600);

Console.WriteLine("Setting the current window to 'Window 1'...");
SplashKit.SetCurrentWindow(wind1);
Console.WriteLine("Current window is now 'Window 1'.");

SplashKit.Delay(1000); // Delay to keep the window open for 1 second

Console.WriteLine("Setting the current window to 'Window 2'...");
SplashKit.SetCurrentWindow(wind2);
Console.WriteLine("Current window is now 'Window 2'.");

SplashKit.Delay(3000); // Delay to keep the window open for 3 seconds
