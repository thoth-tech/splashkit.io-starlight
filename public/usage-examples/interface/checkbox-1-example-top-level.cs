using SplashKitSDK;
using static SplashKitSDK.SplashKit;

OpenWindow("Checkbox Example", 700, 500);

bool showGrid = false;
bool soundEnabled = true;
bool darkBackground = false;

Rectangle panelArea = RectangleFrom(40, 90, 280, 150);
Rectangle positionedCheckbox = RectangleFrom(380, 120, 220, 40);

while (!QuitRequested())
{
    ProcessEvents();

    if (darkBackground)
    {
        ClearScreen(ColorDarkSlateGray());
    }
    else
    {
        ClearScreen(ColorWhite());
    }

    Color textColor = darkBackground ? ColorWhite() : ColorBlack();

    if (showGrid)
    {
        for (int x = 0; x < 700; x += 50)
        {
            DrawLine(ColorLightGray(), x, 0, x, 500);
        }

        for (int y = 0; y < 500; y += 50)
        {
            DrawLine(ColorLightGray(), 0, y, 700, y);
        }
    }

    DrawText(
        "SplashKit Checkbox Example",
        textColor,
        40,
        35
    );

    if (StartPanel("Options", panelArea))
    {
        showGrid = Checkbox(
            "Show Grid",
            showGrid
        );

        soundEnabled = Checkbox(
            "Sound",
            "Enabled",
            soundEnabled
        );

        EndPanel("Options");
    }

    darkBackground = Checkbox(
        "Dark Background",
        darkBackground,
        positionedCheckbox
    );

    DrawText(
        "Try clicking each checkbox",
        textColor,
        380,
        190
    );

    DrawInterface();
    RefreshScreen(60);
}