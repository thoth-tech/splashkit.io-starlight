using static SplashKitSDK.SplashKit;

//Create a window with title Fill rectangle, width 800, height 600.
OpenWindow("Fill Rectangle", 800, 600);

ClearScreen();
//draw three rectangles with color green, yellow, and red with different position as (100,200), (300,200), (500,200) with same size.
FillRectangle(ColorGreen(), 100, 200, 200, 100);
FillRectangle(ColorYellow(), 300, 200, 200, 100);
FillRectangle(ColorRed(), 500, 200, 200, 100);
RefreshScreen();

Delay(4000);

CloseAllWindows();

