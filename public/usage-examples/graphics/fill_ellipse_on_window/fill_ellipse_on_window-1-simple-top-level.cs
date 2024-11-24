using SplashKitSDK;
using static SplashKitSDK.SplashKit;

Window myWindow = OpenWindow("Draw Snowman On Window", 800, 600);

// Draw snowman to window and refresh
ClearScreen(ColorLightBlue());
FillEllipseOnWindow(myWindow, ColorWhite(), 300, 400, 200, 200);
FillEllipseOnWindow(myWindow, ColorWhite(), 320, 240, 160, 160);
FillEllipseOnWindow(myWindow, ColorBlack(), 350, 300, 10, 10);
FillEllipseOnWindow(myWindow, ColorBlack(), 400, 300, 10, 10);
FillTriangleOnWindow(myWindow, ColorOrange(), 325, 330, 375, 320, 375, 340);
RefreshWindow(myWindow);

Delay(6000);
CloseWindow(myWindow);