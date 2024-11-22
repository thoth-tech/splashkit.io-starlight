using SplashKitSDK;
using static SplashKitSDK.SplashKit;

Window myWindow = OpenWindow("Fill Rectangle On Window", 800, 600);

// Define a rectangle to draw
Rectangle rect = RectangleFrom(300, 250, 200, 100); // x, y, width, height

// Fill rectangle on the window and refresh
FillRectangleOnWindow(myWindow, ColorBlue(), rect);
RefreshWindow(myWindow);

Delay(3000);
CloseWindow(myWindow);
