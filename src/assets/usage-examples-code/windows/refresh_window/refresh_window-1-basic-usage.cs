using System;
using SplashKitSDK;

Window wind = SplashKit.OpenWindow("Refresh Window Example", 800, 600);

Console.WriteLine("Refreshing the window...");

SplashKit.ClearWindow(wind, SplashKit.ColorWhite());
SplashKit.DrawText("Window will be refreshed.", SplashKit.ColorBlack(), 50, 50);
SplashKit.RefreshWindow(wind);

Console.WriteLine("Window refreshed.");

SplashKit.Delay(3000); // Delay to keep the window open for 3 seconds
