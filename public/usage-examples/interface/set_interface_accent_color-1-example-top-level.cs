using SplashKitSDK;
using static SplashKitSDK.SplashKit;

OpenWindow("Interface Accent Contrast", 700, 420);

Color accentColor = RGBColor(230, 80, 120);
float contrast = 0.0f;

while (!QuitRequested())
{
    ProcessEvents();

    // Change the interface accent contrast using number keys
    if (KeyTyped(KeyCode.Num1Key))
    {
        contrast = 0.0f;
    }

    if (KeyTyped(KeyCode.Num2Key))
    {
        contrast = 1.0f;
    }

    // Apply the selected accent color and contrast to the interface
    SetInterfaceAccentColor(accentColor, contrast);

    ClearScreen(ColorWhite());

    DrawText(
        "Press 1 for minimum accent or 2 for maximum accent",
        ColorBlack(),
        90,
        70
    );

    DrawText(
        "Hover over the button to see the accent effect",
        ColorBlack(),
        120,
        110
    );

    DrawText(
        "Current contrast: " + contrast,
        ColorBlack(),
        240,
        150
    );

    Button(
        "Hover Over Me",
        RectangleFrom(230, 220, 240, 60)
    );

    DrawInterface();
    RefreshScreen(60);
}

CloseAllWindows();