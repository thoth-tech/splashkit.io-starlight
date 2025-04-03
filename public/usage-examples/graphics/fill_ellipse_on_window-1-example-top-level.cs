using SplashKitSDK;
using static SplashKitSDK.SplashKit;

// Open a new window
Window window = OpenWindow("Ellipse Painter", 800, 600);
ClearScreen();

// While user doesn't request to quit window
while (!WindowCloseRequested(window))
{
    ProcessEvents();
    DrawText("Press on the C key to clear screen", ColorBlack(), 5, 10);

    // If mouse clicked or held down get mouse position 
    if (MouseClicked(MouseButton.LeftButton) || MouseDown(MouseButton.LeftButton))
    {
        Point2D pos = MousePosition();

        // Fill ellipse in the position with random color
        FillEllipseOnWindow(window, RandomColor(), pos.X, pos.Y, 100, 50);
    }

    // Clear screen if C key is pressed 
    if (KeyTyped(KeyCode.CKey))
    {
        ClearScreen();
    }

    RefreshScreen(60);
}

// Close all windows
CloseAllWindows();