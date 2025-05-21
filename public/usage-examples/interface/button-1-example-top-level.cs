using SplashKitSDK;
using static SplashKitSDK.SplashKit;

OpenWindow("Background Color Toggle Button", 600, 400);

// Define the background color and button rectangle
Color bgColor = ColorWhite();
Rectangle btnRect = RectangleFrom(200, 180, 200, 40);

// Continue running until the user closes the window
while (!QuitRequested())
{
    ProcessEvents();

    // If the button is clicked, toggle the background color
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

    // Clear screen and draw interface
    ClearScreen(bgColor);
    Button("Click Me!", btnRect);
    DrawInterface();
    RefreshScreen(60);
}

CloseAllWindows();