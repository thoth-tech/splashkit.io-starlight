using System;
using SplashKitSDK;

Window wind = SplashKit.OpenWindow("Resize Window Example", 800, 600);

Console.WriteLine("Resizing the window to 1024x768...");

SplashKit.ResizeWindow(wind, 1024, 768);

Console.WriteLine("Window resized to 1024x768.");

SplashKit.Delay(3000); // Delay to keep the window open for 3 seconds
