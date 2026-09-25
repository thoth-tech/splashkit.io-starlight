using SplashKitSDK;
using static SplashKitSDK.SplashKit;

OpenWindow("Hue Of", 800, 600);

while (!QuitRequested())
{
    ProcessEvents();

    double selectedHue = MouseX() / ScreenWidth();

    if (selectedHue < 0.0)
    {
        selectedHue = 0.0;
    }
    else if (selectedHue > 1.0)
    {
        selectedHue = 1.0;
    }

    Color selectedColor = HSBColor(selectedHue, 1.0, 1.0);

    // Get the hue component of the selected color
    double hue = HueOf(selectedColor);

    ClearScreen(ColorWhite());

    FillRectangle(selectedColor, 100, 120, 600, 300);
    DrawRectangle(ColorBlack(), 100, 120, 600, 300);

    DrawText(
        "Move the mouse left and right to change the color",
        ColorBlack(),
        150,
        60
    );

    DrawText(
        $"Hue: {hue:F3}",
        ColorBlack(),
        330,
        460
    );

    RefreshScreen(60);
}

CloseAllWindows();