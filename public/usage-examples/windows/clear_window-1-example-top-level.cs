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
    ClearWindow(wind, Color.White);

    if (Button("Red!", RectangleFrom(75, 85, 100, 30)))
    {
        ClearWindow(wind, Color.Red);
        RefreshWindow(wind);
        Delay(1000);
        continue;
    }

    if (Button("Green!", RectangleFrom(250, 85, 100, 30)))
    {
        ClearWindow(wind, Color.Green);
        RefreshWindow(wind);
        Delay(1000);
        continue;
    }

    if (Button("Blue!", RectangleFrom(425, 85, 100, 30)))
    {
        ClearWindow(wind, Color.Blue);
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