using System;
using SplashKitSDK;

Window wind = SplashKit.OpenWindow("Refresh Window with Target FPS Example", 800, 600);

uint targetFps = 60;

Console.WriteLine("Refreshing the window with a target FPS of " + targetFps + "...");

while (!SplashKit.WindowCloseRequested(wind))
{
    SplashKit.ProcessEvents();
    SplashKit.ClearWindow(wind, SplashKit.ColorWhite());
    SplashKit.DrawText("Window will be refreshed at " + targetFps + " FPS.", SplashKit.ColorBlack(), 50, 50);
    SplashKit.RefreshWindow(wind, targetFps);
}
