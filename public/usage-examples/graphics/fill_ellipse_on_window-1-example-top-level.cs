using SplashKitSDK;
using static SplashKitSDK.SplashKit;

// Open new windows
Window whiteWindow = OpenWindow("Ellipse Painter on White", 500, 500);
Window blueWindow = OpenWindow("Ellipse Painter on Blue", 500, 500);

// Set windows' postions
MoveWindowTo(whiteWindow, 100, 100);
MoveWindowTo(blueWindow, 620, 100);

// Clear windows to white and blue
ClearWindow(whiteWindow, ColorWhite());
ClearWindow(blueWindow, ColorAqua());

// While user doesn't request to quit windows
while (!WindowCloseRequested(whiteWindow) && !WindowCloseRequested(blueWindow))
{
    ProcessEvents();
    DrawTextOnWindow(whiteWindow, "Press L to paint. Press on the C key to clear screen", ColorBlack(), 5, 10);
    DrawTextOnWindow(blueWindow, "Press P to paint. Press on the D key to clear screen", ColorBlack(), 5, 10);

    // Get random points on the windows
    Point2D whitePos = RandomWindowPoint(whiteWindow);
    Point2D bluePos = RandomWindowPoint(blueWindow);

    // If L key is pressed draw ellipse on whiteWindow in random point
    if (KeyTyped(KeyCode.LKey))
    {
        FillEllipseOnWindow(whiteWindow, RandomColor(), whitePos.X, whitePos.Y, 100, 50);
    }
    
    // If P key is pressed draw ellipse on blueWindow in random point
    if (KeyTyped(KeyCode.PKey))
    {
        FillEllipseOnWindow(blueWindow, RandomColor(), bluePos.X, bluePos.Y, 100, 50);
    }

    // Clear whiteWindow if C key is pressed 
    if (KeyTyped(KeyCode.CKey))
    {
        ClearWindow(whiteWindow, ColorWhite());

    }
    // Clear blueWindow if D key is pressed 
    if (KeyTyped(KeyCode.DKey))
    {
        ClearWindow(blueWindow, ColorAqua());
    }

    RefreshWindow(whiteWindow, 60);
    RefreshWindow(blueWindow, 60);
}

// Close all windows
CloseAllWindows();