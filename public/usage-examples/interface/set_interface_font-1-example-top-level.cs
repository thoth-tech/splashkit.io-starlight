using SplashKitSDK;
using static SplashKitSDK.SplashKit;

// Open a window for the button font
OpenWindow("Button Interface Font", 800, 600);

// Load and register the Courier font for UI elements
LoadFont("courier", "courier.ttf");
SetInterfaceFont("courier");

// Define a button area
Rectangle btnRect = RectangleFrom(300, 250, 200, 60);

// Main loop: draw the button with our chosen interface font
while (!QuitRequested())
{
    ProcessEvents();
    ClearScreen(ColorWhite());

    // Draw a button labeled "Click Me!" using the interface font
    Button("Just a button", btnRect);

    // Render all interface elements
    DrawInterface();
    RefreshScreen(60);
}

CloseAllWindows();
