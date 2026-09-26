using static SplashKitSDK.SplashKit;
using SplashKitSDK;

// Open a new window
Window myWindow = OpenWindow("My SplashKit Window", 800, 600);

// Get the window caption
string caption = WindowCaption(myWindow);

// Keep the program running until the user closes the window
while (!QuitRequested())
{
    ProcessEvents();

    // Draw content on the screen
    ClearWindow(myWindow, ColorWhite());

    DrawText("Window caption:", ColorBlack(), 260, 250);
    DrawText(caption, ColorBlue(), 260, 290);

    RefreshWindow(myWindow);
}

// Close all open windows
CloseAllWindows();