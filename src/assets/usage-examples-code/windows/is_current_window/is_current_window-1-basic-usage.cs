using System;
using SplashKitSDK;

Window wind1 = SplashKit.OpenWindow("Window 1", 800, 600);
Window wind2 = SplashKit.OpenWindow("Window 2", 800, 600);

if (SplashKit.IsCurrentWindow(wind1))
{
    Console.WriteLine("Window 1 is the current window.");
}
else
{
    Console.WriteLine("Window 1 is not the current window.");
}

if (SplashKit.IsCurrentWindow(wind2))
{
    Console.WriteLine("Window 2 is the current window.");
}
else
{
    Console.WriteLine("Window 2 is not the current window.");
}
