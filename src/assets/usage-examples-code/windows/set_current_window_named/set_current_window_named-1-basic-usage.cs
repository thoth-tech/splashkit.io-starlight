using System;
using SplashKitSDK;

string window1Name = "Window 1";
string window2Name = "Window 2";

Window wind1 = SplashKit.OpenWindow(window1Name, 800, 600);
Window wind2 = SplashKit.OpenWindow(window2Name, 800, 600);

Console.WriteLine("Setting the current window to '" + window1Name + "'...");
SplashKit.SetCurrentWindow(window1Name);
Console.WriteLine("Current window is now '" + window1Name + "'.");

SplashKit.Delay(1000); // Delay to keep the window open for 1 second

Console.WriteLine("Setting the current window to '" + window2Name + "'...");
SplashKit.SetCurrentWindow(window2Name);
Console.WriteLine("Current window is now '" + window2Name + "'.");

SplashKit.Delay(3000); // Delay to keep the window open for 3 seconds
