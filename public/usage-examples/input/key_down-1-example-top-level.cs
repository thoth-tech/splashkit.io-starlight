using SplashKitSDK;
using static SplashKitSDK.SplashKit;

void DrawKeyStatus(string label, KeyCode key, double x, double y)
{
    bool pressed = KeyDown(key);

    Color indicator;
    string state;

    if (pressed)
    {
        indicator = Color.Green;
        state = "Pressed";
    }
    else
    {
        indicator = Color.Gray;
        state = "Released";
    }

    FillCircle(indicator, x, y, 25);
    DrawText(label + ": " + state, Color.Black, x + 40, y - 10);
}

OpenWindow("Keyboard State Display", 800, 400);

while (!QuitRequested())
{
    ProcessEvents();

    ClearScreen(Color.White);

    DrawText("Press the arrow keys or space bar to see their current state.", Color.Black, 120, 40);

    DrawKeyStatus("Left", KeyCode.LeftKey, 120, 130);
    DrawKeyStatus("Right", KeyCode.RightKey, 120, 190);
    DrawKeyStatus("Up", KeyCode.UpKey, 120, 250);
    DrawKeyStatus("Down", KeyCode.DownKey, 120, 310);
    DrawKeyStatus("Space", KeyCode.SpaceKey, 500, 220);

    RefreshScreen(60);
}

CloseAllWindows();
