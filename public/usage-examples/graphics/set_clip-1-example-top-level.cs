using SplashKitSDK;
using static SplashKitSDK.SplashKit;

OpenWindow("Set Clip Example", 600, 600);

// Define a rectangle as the clip area
Rectangle clipRect = RectangleFrom(100, 100, 400, 200);

// Set the clip rectangle for the current window
SetClip(clipRect);

// Draw a background so we can see the clip area
ClearScreen(ColorWhite());

// Draw the outline of the clip area for visualization
DrawRectangle(ColorBlack(), clipRect);

// Only the part of the red rectangle inside the clip will be visible
FillRectangle(ColorRed(), 50, 50, 500, 300);

// Draw a circle; only the part inside the clip area will be visible
FillCircle(ColorBlue(), 300, 200, 150);

RefreshScreen();
Delay(3000);

// Remove the clipping (restore drawing to full window)
PopClip();

// Draw more shapes, now visible everywhere
FillRectangle(ColorGreen(), 0, 500, 600, 80);

RefreshScreen();
Delay(2000);

CloseAllWindows();
