using SplashKitSDK;
using static SplashKitSDK.SplashKit;

// Open the window
OpenWindow("Background Color Toggle Button", 600, 400);

Color bgColor = ColorWhite();
Rectangle btnRect = RectangleFrom(200, 180, 200, 40);

// Main loop
while (!QuitRequested())
{
    ProcessEvents();

    // Alternate background color to give click feedback
    if (Button("Click Me!", btnRect))
    {
        if (bgColor == ColorWhite())
        {
            bgColor = ColorLightBlue();
        }
        else
        {
            bgColor = ColorWhite();
        }
    }

    // Draw background and interface
    ClearScreen(bgColor);
    Button("Click Me!", btnRect);
    DrawInterface();
    RefreshScreen(60);
}

CloseAllWindows();