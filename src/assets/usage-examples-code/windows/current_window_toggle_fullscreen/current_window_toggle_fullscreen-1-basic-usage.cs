using System;
using SplashKitSDK;

SplashKit.OpenWindow("Fullscreen Toggle Example", 800, 600);

Console.WriteLine("Press any key to toggle fullscreen mode...");
Console.ReadLine();

// Toggle fullscreen mode
SplashKitSDK.SplashKit.CurrentWindowToggleFullscreen();

Console.WriteLine("Fullscreen mode toggled. Press any key to exit...");
Console.ReadLine();
