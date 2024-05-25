using System;
using SplashKitSDK;

SplashKit.OpenWindow("Window Width Example", 800, 600);

int width = SplashKit.CurrentWindowWidth();

Console.WriteLine("The width of the current window is: " + width);
