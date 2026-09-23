using SplashKitSDK;
using static SplashKitSDK.SplashKit;

OpenWindow("Interface Element Contrast", 700, 420);

Color elementColor = RGBColor(70, 160, 220);
float contrast = 0.0f;

while (!QuitRequested())
{
    ProcessEvents();

    // Change the interface contrast using number keys
    if (KeyTyped(KeyCode.Num1Key))
    {
        contrast = 0.0f;
    }

    if (KeyTyped(KeyCode.Num2Key))
    {
        contrast = 1.0f;
    }

    // Apply the selected color and contrast to the interface
    SetInterfaceElementColor(elementColor, contrast);

    ClearScreen(ColorWhite());

    DrawText(
        "Press 1 for minimum contrast or 2 for maximum contrast",
        ColorBlack(),
        90,
        80
    );

    DrawText(
        "Current contrast: " + contrast,
        ColorBlack(),
        240,
        130
    );

    Button(
        "Interface Button",
        RectangleFrom(230, 200, 240, 60)
    );

    DrawInterface();
    RefreshScreen(60);
}

CloseAllWindows();