using static SplashKitSDK.SplashKit;
using SplashKitSDK;

// Open a window to display the random colours
Window wind = OpenWindow("Random Colour Grid", 640, 480);

while (!QuitRequested())
{
    ProcessEvents();

    // Clear the screen before drawing
    ClearWindow(wind, ColorWhite());

    // Draw a grid of squares with random colours
    for (int row = 0; row < 4; row++)
    {
        for (int col = 0; col < 4; col++)
        {
            Color randomColour = RandomRgbColor(255);

            FillRectangle(randomColour, 80 + col * 120, 80 + row * 80, 80, 50);
            DrawRectangle(ColorBlack(), 80 + col * 120, 80 + row * 80, 80, 50);
        }
    }

    // Add a label to explain the example
    DrawText("Each square uses RandomRgbColor()", ColorBlack(), 150, 420);

    // Refresh the window to show updated colours
    RefreshWindow(wind);
}

// Close the window when the program ends
CloseAllWindows();