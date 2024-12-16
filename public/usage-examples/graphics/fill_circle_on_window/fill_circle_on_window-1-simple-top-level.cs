using static SplashKitSDK.SplashKit;

// Open a new window and initialize to a window variable wnd1
SplashKitSDK.Window wnd1 = OpenWindow("Traffic Lights", 800, 600);
ClearScreen();

// Use function to place 3 circles in destination window (wnd1) as traffic lights
FillCircleOnWindow(wnd1, ColorRed(), 400, 100, 50);
FillCircleOnWindow(wnd1, ColorYellow(), 400, 250, 50);
FillCircleOnWindow(wnd1, ColorGreen(), 400, 400, 50);

RefreshScreen();
Delay(5000);

//Close loaded windows   
CloseAllWindows();