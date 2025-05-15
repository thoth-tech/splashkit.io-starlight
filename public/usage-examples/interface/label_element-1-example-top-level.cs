using SplashKitSDK;
using static SplashKitSDK.SplashKit;

// Open a window
OpenWindow("SplashKit Interface Demo", 600, 400);

while (!WindowCloseRequested("SplashKit Interface Demo"))
{
    ProcessEvents();
    ClearScreen(Color.White);

    // Define the main panel
    Rectangle main_panel_area = RectangleFrom(50, 50, 500, 300);

    // Create the panel
    StartPanel("MainPanel", main_panel_area);

    // Add label to the panel
    LabelElement("Welcome to the SplashKit Interface!");
    EndPanel("MainPanel");

    // Draw all panels and interface elements
    DrawInterface();

    RefreshScreen(60);
}
