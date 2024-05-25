using System;
using SplashKitSDK;

string caption = "Test Window";
SplashKit.OpenWindow(caption, 800, 600);

if (SplashKit.HasWindow(caption))
{
    Console.WriteLine("A window with the caption '" + caption + "' exists.");
}
else
{
    Console.WriteLine("No window with the caption '" + caption + "' exists.");
}
