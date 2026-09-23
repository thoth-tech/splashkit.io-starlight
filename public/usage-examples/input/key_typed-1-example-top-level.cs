using SplashKitSDK;
using static SplashKitSDK.SplashKit;

OpenWindow("Typed Key Counter", 800, 600);

int aCount = 0;
int spaceCount = 0;
int enterCount = 0;
string lastTypedKey = "None";

while (!QuitRequested())
{
    ProcessEvents();

    // Count each key once when it is first pressed.
    if (KeyTyped(KeyCode.AKey))
    {
        aCount++;
        lastTypedKey = "A";
    }

    if (KeyTyped(KeyCode.SpaceKey))
    {
        spaceCount++;
        lastTypedKey = "Space";
    }

    if (KeyTyped(KeyCode.ReturnKey))
    {
        enterCount++;
        lastTypedKey = "Enter";
    }

    ClearScreen(ColorWhite());

    DrawText("Press A, Space, or Enter.", ColorBlack(), 20, 20);
    DrawText("Hold a key down and the count only changes once.", ColorBlack(), 20, 50);
    DrawText("Last typed key: " + lastTypedKey, ColorBlack(), 20, 100);
    DrawText("A count: " + aCount, ColorBlack(), 20, 150);
    DrawText("Space count: " + spaceCount, ColorBlack(), 20, 190);
    DrawText("Enter count: " + enterCount, ColorBlack(), 20, 230);

    RefreshScreen(60);
}