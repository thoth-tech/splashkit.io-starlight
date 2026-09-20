using SplashKitSDK;
using static SplashKitSDK.SplashKit;

// Open the window for the usage example
OpenWindow("Reading the Blue Channel", 800, 400);

Color[] shades =
{
    RGBAColor(80, 80, 30, 255),
    RGBAColor(80, 80, 130, 255),
    RGBAColor(80, 80, 230, 255)
};

string[] labels = { "Low Blue", "Medium Blue", "High Blue" };

while (!QuitRequested())
{
    ProcessEvents();

    // Draw the background and instructions
    ClearScreen(Color.White);
    DrawText("Blue values for these shades", Color.Black, 240, 40);

    // Draw each shade and use blue_of to read its blue component
    for (int i = 0; i < 3; i++)
    {
        int value = BlueOf(shades[i]);

        FillRectangle(shades[i], 80 + i * 240, 140, 160, 80);
        DrawText(labels[i], Color.Black, 115 + i * 240, 250);
        DrawText("Blue: " + value.ToString(), Color.Black, 115 + i * 240, 290);
    }

    RefreshScreen(60);
}

CloseAllWindows();
