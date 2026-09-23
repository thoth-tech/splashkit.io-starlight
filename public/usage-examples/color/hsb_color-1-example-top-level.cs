using SplashKitSDK;
using static SplashKitSDK.SplashKit;

OpenWindow("HSB Color", 800, 600);

double hue = 0.0;
double saturation = 1.0;
double brightness = 1.0;

while (!QuitRequested())
{
    ProcessEvents();

    // Use the keyboard to adjust the HSB values.
    if (KeyDown(KeyCode.LeftKey))
    {
        hue -= 0.005;
    }

    if (KeyDown(KeyCode.RightKey))
    {
        hue += 0.005;
    }

    if (KeyDown(KeyCode.DownKey))
    {
        saturation -= 0.005;
    }

    if (KeyDown(KeyCode.UpKey))
    {
        saturation += 0.005;
    }

    if (KeyDown(KeyCode.SKey))
    {
        brightness -= 0.005;
    }

    if (KeyDown(KeyCode.WKey))
    {
        brightness += 0.005;
    }

    // Keep each HSB value between 0 and 1.
    hue = Math.Clamp(hue, 0.0, 1.0);
    saturation = Math.Clamp(saturation, 0.0, 1.0);
    brightness = Math.Clamp(brightness, 0.0, 1.0);

    // Create a color from the current HSB values.
    Color selectedColor = HSBColor(
        hue,
        saturation,
        brightness
    );

    // Draw the selected color and its current values.
    ClearScreen(ColorBlack());

    FillRectangle(
        selectedColor,
        250,
        120,
        300,
        260
    );

    DrawText(
        $"Hue: {hue:F2}",
        ColorWhite(),
        40,
        430
    );

    DrawText(
        $"Saturation: {saturation:F2}",
        ColorWhite(),
        40,
        460
    );

    DrawText(
        $"Brightness: {brightness:F2}",
        ColorWhite(),
        40,
        490
    );

    DrawText(
        "Left/Right: Hue   Up/Down: Saturation   W/S: Brightness",
        ColorWhite(),
        40,
        530
    );

    RefreshScreen(60);
}

CloseAllWindows();