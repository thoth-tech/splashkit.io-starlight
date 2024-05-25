using System;
using SplashKitSDK;

SplashKit.OpenWindow("Move Window Example", 800, 600);

Console.WriteLine("Moving the window to (100, 100)...");

SplashKit.MoveCurrentWindowTo(100, 100);

Console.WriteLine("Window moved to (100, 100).");
