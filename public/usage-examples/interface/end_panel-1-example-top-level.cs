using static SplashKitSDK.SplashKit;

// Open a window
OpenWindow("Panel Example", 600, 400);

while (!QuitRequested())
{
    ProcessEvents();
    ClearScreen(Color.White);

    // Define the panel
    var panelArea = RectangleFrom(50, 50, 500, 300);

    // Start the panel
    StartPanel("MainPanel", panelArea);

    // Add Labels to the panel
    LabelElement("Hello, welcome to the panel example!");
    LabelElement("This panel is now finalized with end_panel()");

    // Finalize the panel - no more elements can be added after this point
    EndPanel("MainPanel");

    // Draw the interface elements (all panels and labels)
    DrawInterface();

    RefreshScreen(60);
}
