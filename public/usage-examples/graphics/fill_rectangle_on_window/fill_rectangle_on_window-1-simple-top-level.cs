using SplashKitSDK;
using static SplashKitSDK.SplashKit;

Window myWindow = OpenWindow("Fill Rectangle On Window", 800, 600);

// Fill rectangle on the window and refresh
FillRectangleOnWindow(myWindow, ColorBlue(), 300, 250, 200, 100);
RefreshWindow(myWindow);

Delay(3000);
CloseWindow(myWindow);
