using SplashKitSDK;
using static SplashKitSDK.SplashKit;

Window myWindow = OpenWindow("Draw Snowman On Window", 800, 600);

// Define rectangles for each ellipse
Rectangle body = RectangleFrom(300, 400, 200, 200);
Rectangle head = RectangleFrom(320, 240, 160, 160);
Rectangle leftEye = RectangleFrom(350, 300, 10, 10);
Rectangle rightEye = RectangleFrom(400, 300, 10, 10);

// Draw snowman to window and refresh
ClearScreen(ColorLightBlue());
FillEllipseOnWindow(myWindow, ColorWhite(), body);
FillEllipseOnWindow(myWindow, ColorWhite(), head);
FillEllipseOnWindow(myWindow, ColorBlack(), leftEye);
FillEllipseOnWindow(myWindow, ColorBlack(), rightEye);
FillTriangleOnWindow(myWindow, ColorOrange(), 325, 330, 375, 320, 375, 340);
RefreshWindow(myWindow);

Delay(6000);
CloseWindow(myWindow);