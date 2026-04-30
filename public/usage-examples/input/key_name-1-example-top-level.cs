using SplashKitSDK;
using static SplashKitSDK.SplashKit;

OpenWindow("Key Name", 800, 600);

// Store the last key typed from this example's set of demo keys
KeyCode lastKey = KeyCode.UnknownKey;

while (!QuitRequested())
{
    ProcessEvents();

    // Check which demo key was typed and save its key code
    if (KeyTyped(KeyCode.AKey)) lastKey = KeyCode.AKey;
    if (KeyTyped(KeyCode.Num1Key)) lastKey = KeyCode.Num1Key;
    if (KeyTyped(KeyCode.SpaceKey)) lastKey = KeyCode.SpaceKey;
    if (KeyTyped(KeyCode.LeftKey)) lastKey = KeyCode.LeftKey;
    if (KeyTyped(KeyCode.ReturnKey)) lastKey = KeyCode.ReturnKey;

    // Draw the instructions and the readable name of the last key
    ClearScreen(ColorWhite());
    DrawText("Press A, 1, Space, Left, or Enter", ColorBlack(), 150, 220);
    DrawText("Last key: " + KeyName(lastKey), ColorBlue(), 280, 300);
    RefreshScreen();
}

CloseAllWindows();
