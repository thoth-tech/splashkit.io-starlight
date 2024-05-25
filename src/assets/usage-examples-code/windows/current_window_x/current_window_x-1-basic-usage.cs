using System;
using SplashKitSDK;

SplashKit.OpenWindow("Window X Coordinate Example", 800, 600);

int xPosition = SplashKit.CurrentWindowX();

Console.WriteLine("The x-coordinate of the current window is: " + xPosition);
