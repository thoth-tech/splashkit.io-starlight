using SplashKitSDK;
using static SplashKitSDK.SplashKit;

OpenWindow("Color Bright Green", 300, 540);

ClearScreen(ColorWhite());

// The body of the traffic light
FillRectangle(ColorBlack(), 60, 40, 180, 420);

// The red and amber lights are switched off, so they are drawn dark gray
FillCircle(ColorDarkGray(), 150, 110, 50);
FillCircle(ColorDarkGray(), 150, 250, 50);

// The green light is on - ColorBrightGreen stands out against the black body
// Function used here ↓
FillCircle(ColorBrightGreen(), 150, 390, 50);

DrawText("GO - ColorBrightGreen", ColorBrightGreen(), 70, 490);

RefreshScreen();

Delay(5000);

CloseAllWindows();
