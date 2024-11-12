using SplashKitSDK;
using static SplashKitSDK.SplashKit;


// Create wubdow
Window start = OpenWindow("draw_line_on_window", 600, 600);
ClearScreen(ColorBlack());


// Draw line on window - param (Window, Color, x1, y1, x2, y2)
DrawLineOnWindow(start, ColorYellow(), 0,0,600,600);
DrawLineOnWindow(start, ColorGreen(), 0,150,600,450);
DrawLineOnWindow(start, ColorTeal(), 0,300,600,300);
DrawLineOnWindow(start, ColorBlue(), 0,450,600,150);
DrawLineOnWindow(start, ColorViolet(), 0,600,600,0);
DrawLineOnWindow(start, ColorPurple(), 150,0,450,600);
DrawLineOnWindow(start, ColorPink(), 300,0,300,600);
DrawLineOnWindow(start, ColorRed(), 450,0,150,600);      
DrawLineOnWindow(start, ColorOrange(), 600,0,0,600);
RefreshScreen();
Delay(5000);
CloseAllWindows();
