using SplashKitSDK;
using static SplashKitSDK.SplashKit;

// Create and initialise new window with title and dimensions
SplashKitSDK.Window wnd = OpenWindow("Distance From Center", 600, 600);
ClearScreen();

// Create circle at the center of window 
FillCircleOnWindow(wnd, ColorRed(), 300, 300, 6);
RefreshScreen();

// While window is open 
while(!QuitRequested())
{
    ProcessEvents();

    // Point of center 
    Point2D center = ScreenCenter();

    // Point of cursor position 
    Point2D mouse = MousePosition();

    // Print distance to terminal 
    WriteLine(PointPointDistance(center, mouse));
}

// Close all opened windows
CloseAllWindows();

