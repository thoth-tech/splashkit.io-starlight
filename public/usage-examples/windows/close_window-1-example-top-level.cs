using SplashKitSDK;
using static SplashKitSDK.SplashKit;

// open a window
Window window = new Window("Close Window Example", 400, 200);

bool countdownStarted = false;
int countdown = 5;
// SplashKitSDK.Timer needed to distinguish from System.Threading.Timer
SplashKitSDK.Timer countdownTimer = new SplashKitSDK.Timer("countdown");

// main loop
while (!window.CloseRequested)
{
    // get user events
    ProcessEvents();

    // clear screen
    window.Clear(Color.White);

    if (!countdownStarted)
    {
        // Show the button before countdown starts
        if (Button("Click Me!", RectangleFrom(150, 85, 100, 30)))
        {
            countdownStarted = true;
            StartTimer(countdownTimer);
        }
    }
    else
    {
        // Display countdown
        DrawText($"This window will close in {countdown}", Color.Black, "arial", 18, 50, 85);

        // Check if 1 second has passed
        if (TimerTicks(countdownTimer) > 1000)
        {
            countdown--;
            ResetTimer(countdownTimer);

            if (countdown <= 0)
            {
                CloseWindow(window);
                break;
            }
        }
    }

    // draw interface and refresh
    DrawInterface();
    window.Refresh();
}

// close all open windows
CloseAllWindows();