using SplashKitSDK;
using static SplashKitSDK.SplashKit;

// open a window
Window wind = OpenWindow("Colour Changer", 600, 200);

// main loop
while (!QuitRequested())
{
    // get user events
    ProcessEvents();

    // clear screen
    ClearWindow(wind, ColorWhite());

    if (Button("Red!", RectangleFrom(75, 85, 100, 30)))
    {
        ClearWindow(wind, ColorRed());
        RefreshWindow(wind);
        Delay(1000);
        continue;
    }

    if (Button("Green!", RectangleFrom(250, 85, 100, 30)))
    {
        ClearWindow(wind, ColorGreen());
        RefreshWindow(wind);
        Delay(1000);
        continue;
    }

    if (Button("Blue!", RectangleFrom(425, 85, 100, 30)))
    {
        ClearWindow(wind, ColorBlue());
        RefreshWindow(wind);
        Delay(1000);
        continue;
    }
    // finally draw interface, then refresh window
    DrawInterface();
    RefreshWindow(wind);
}

// close all open windows
CloseAllWindows();