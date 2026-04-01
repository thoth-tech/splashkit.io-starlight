using static SplashKitSDK.SplashKit;

// Open the window for the usage example
OpenWindow("Purple Shade Brightness", 800, 400);

Color[] shades =
{
    RGBAColor(70, 30, 100, 255),
    RGBAColor(140, 70, 180, 255),
    RGBAColor(210, 170, 240, 255)
};

string[] names = { "Dark Purple", "Medium Purple", "Light Purple" };

while (!QuitRequested())
{
    ProcessEvents();

    // Draw the background and instructions
    ClearScreen(Color.White);
    DrawText("Brightness values of purple shades", Color.Black, 210, 40);

    // Draw each shade and its brightness value
    for (int i = 0; i < 3; i++)
    {
        double value = BrightnessOf(shades[i]);

        FillCircle(shades[i], 150 + i * 240, 180, 55);
        DrawText(names[i], Color.Black, 105 + i * 240, 260);
        DrawText("Brightness: " + value.ToString(), Color.Black, 75 + i * 240, 300);
    }

    RefreshScreen(60);
}

CloseAllWindows();
