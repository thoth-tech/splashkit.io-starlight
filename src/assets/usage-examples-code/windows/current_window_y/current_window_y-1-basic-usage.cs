using System;
using SplashKitSDK;

SplashKit.OpenWindow("Window Y Coordinate Example", 800, 600);

int yPosition = SplashKit.CurrentWindowY();

Console.WriteLine("The y-coordinate of the current window is: " + yPosition);
