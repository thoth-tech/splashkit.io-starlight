using SplashKitSDK;
using static SplashKitSDK.SplashKit;

// Open a window for the border‐color demo
OpenWindow("Border Interface Color", 400, 200);

// Set all interface borders (e.g. buttons) to red
SetInterfaceBorderColor(ColorRed());

// Define a button area
var btnRect = RectangleFrom(150, 80, 100, 40);

// Main loop: draw the button with our custom border color
while (!QuitRequested())
{
    ProcessEvents();
    ClearScreen(ColorWhite());

    // Render the button using the interface border color
    Button("Click Me", btnRect);
    DrawInterface();

    RefreshScreen(60);
}

CloseAllWindows();
