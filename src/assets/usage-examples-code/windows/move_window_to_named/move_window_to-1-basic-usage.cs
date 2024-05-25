using System;
using SplashKitSDK;

string windowName = "Move Named Window Example";
Window wind = SplashKit.OpenWindow(windowName, 800, 600);

Console.WriteLine("Moving the window '" + windowName + "' to (100, 100)...");

SplashKit.MoveWindowTo(windowName, 100, 100);

Console.WriteLine("Window '" + windowName + "' moved to (100, 100).");
