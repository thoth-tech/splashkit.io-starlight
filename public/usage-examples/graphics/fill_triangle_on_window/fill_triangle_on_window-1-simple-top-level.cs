using SplashKitSDK;
using static SplashKitSDK.SplashKit;

Window myWindow = OpenWindow("Fill Triangle On Window", 800, 600);

// Fill triangle on the window and refresh
FillTriangleOnWindow(myWindow, ColorBlue(), 300, 250, 500, 250, 400, 350);
RefreshWindow(myWindow);

Delay(3000);
CloseWindow(myWindow);
