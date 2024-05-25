using System;
using SplashKitSDK;

SplashKit.OpenWindow("Resize Current Window Example", 800, 600);

Console.WriteLine("Resizing the window to 1024x768...");

SplashKit.ResizeCurrentWindow(1024, 768);

Console.WriteLine("Window resized to 1024x768.");

SplashKit.Delay(3000); // Delay to keep the window open for 3 seconds
