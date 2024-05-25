using System;
using SplashKitSDK;

Window wind = SplashKit.OpenWindow("Move Window Object Example", 800, 600);

Console.WriteLine("Moving the window to (100, 100)...");

SplashKit.MoveWindowTo(wind, 100, 100);

Console.WriteLine("Window moved to (100, 100).");
