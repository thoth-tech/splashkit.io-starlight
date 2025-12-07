using static SplashKitSDK.SplashKit;

OpenWindow("Free Animation Script Example", 800, 600);

// Load animation script
var script = LoadAnimationScript("kermit", "kermit.txt");
bool scriptLoaded = true;

var anim = CreateAnimation(script, "SplashKitOnlineDemo");
bool animationExists = true;

while (!QuitRequested())
{
    ProcessEvents();

    ClearScreen(ColorWhite());

    // Display instructions
    DrawText("Free Animation Script Demo", ColorBlack(), 280, 100);

    if (scriptLoaded)
    {
        DrawText("Script Status: LOADED", ColorGreen(), 300, 200);

        if (animationExists)
        {
            DrawText($"Animation Cell: {AnimationCurrentCell(anim)}", ColorBlue(), 300, 250);
            UpdateAnimation(anim);
        }

        DrawText("Press F to free animation script", ColorOrange(), 260, 400);
        DrawText("(Will also free the animation)", ColorGray(), 280, 430);

        if (KeyTyped(KeyCode.FKey))
        {
            // First free the animation that uses this script
            if (animationExists)
            {
                FreeAnimation(anim);
                animationExists = false;
            }
            // Then free the animation script
            FreeAnimationScript(script);
            scriptLoaded = false;
        }
    }
    else
    {
        DrawText("Script Status: FREED", ColorRed(), 300, 200);
        DrawText("Press L to load new script", ColorOrange(), 280, 400);

        if (KeyTyped(KeyCode.LKey))
        {
            script = LoadAnimationScript("kermit", "kermit.txt");
            scriptLoaded = true;
            anim = CreateAnimation(script, "SplashKitOnlineDemo");
            animationExists = true;
        }
    }

    DrawText("Press ESC to exit", ColorGray(), 320, 500);

    RefreshScreen(60);
}

// Final cleanup
if (animationExists)
{
    FreeAnimation(anim);
}
if (scriptLoaded)
{
    FreeAnimationScript(script);
}

CloseAllWindows();
