using SplashKitSDK;
using static SplashKitSDK.SplashKit;

// Open the window
OpenWindow("Button Toggle", 600, 400);

Color bgColor = ColorWhite();
Rectangle btnRect = RectangleFrom(200, 180, 200, 40);

// Main loop
while (!QuitRequested())
{
    ProcessEvents();

    // If the button is clicked, toggle the background color
    if (Button("Click Me!", btnRect))
    {
        bgColor = (bgColor == ColorWhite()) ? ColorLightBlue() : ColorWhite();
    }

    // Draw background and interface
    ClearScreen(bgColor);
    Button("Click Me!", btnRect);
    DrawInterface();
    RefreshScreen(60);
}

CloseAllWindows();
