using SplashKitSDK;
using static SplashKitSDK.SplashKit;

Window myWindow = OpenWindow("Fill Triangle On Window", 800, 600);

// Define a triangle to draw
Triangle tri = TriangleFrom(300, 250, 500, 250, 400, 350);

// Fill triangle on the window and refresh
FillTriangleOnWindow(myWindow, ColorBlue(), tri);
RefreshWindow(myWindow);

Delay(3000);
CloseWindow(myWindow);
