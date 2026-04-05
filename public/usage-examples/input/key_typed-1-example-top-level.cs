using SplashKitSDK;
using static SplashKitSDK.SplashKit;

KeyCode[] trackedKeys =
{
    KeyCode.AKey, KeyCode.BKey, KeyCode.CKey, KeyCode.DKey, KeyCode.EKey,
    KeyCode.FKey, KeyCode.GKey, KeyCode.HKey, KeyCode.IKey, KeyCode.JKey,
    KeyCode.KKey, KeyCode.LKey, KeyCode.MKey, KeyCode.NKey, KeyCode.OKey,
    KeyCode.PKey, KeyCode.QKey, KeyCode.RKey, KeyCode.SKey, KeyCode.TKey,
    KeyCode.UKey, KeyCode.VKey, KeyCode.WKey, KeyCode.XKey, KeyCode.YKey, KeyCode.ZKey,
    KeyCode.Num0Key, KeyCode.Num1Key, KeyCode.Num2Key, KeyCode.Num3Key, KeyCode.Num4Key,
    KeyCode.Num5Key, KeyCode.Num6Key, KeyCode.Num7Key, KeyCode.Num8Key, KeyCode.Num9Key,
    KeyCode.SpaceKey, KeyCode.EscapeKey
};

string lastKey = "None";

OpenWindow("Last Typed Key", 800, 600);

while (!QuitRequested())
{
    ProcessEvents();

    // Update the text when a supported key is typed
    foreach (KeyCode key in trackedKeys)
    {
        if (KeyTyped(key))
        {
            lastKey = KeyName(key);
        }
    }

    ClearScreen(ColorWhite());

    DrawText("Press a supported key", ColorBlack(), 20, 20);
    DrawText($"Last typed: {lastKey}", ColorBlue(), 20, 80);

    RefreshScreen();
}

CloseAllWindows();