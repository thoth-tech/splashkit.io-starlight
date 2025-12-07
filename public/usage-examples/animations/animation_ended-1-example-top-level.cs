using static SplashKitSDK.SplashKit;

OpenWindow("Animation Ended Example", 800, 600);

// Load animation script and create animation
var script = LoadAnimationScript("kermit", "kermit.txt");
var anim = CreateAnimation(script, "SplashKitOnlineDemo");

while (!QuitRequested())
{
    ProcessEvents();

    ClearScreen(ColorWhite());

    // Display animation state
    DrawText("Animation Ended Example", ColorBlack(), 280, 100);
    DrawText($"Current Cell: {AnimationCurrentCell(anim)}", ColorBlue(), 300, 200);

    // Check if animation has ended using animation_ended
    if (AnimationEnded(anim))
    {
        DrawText("Animation Status: ENDED", ColorRed(), 300, 250);
        DrawText("Press R to restart", ColorOrange(), 310, 350);

        if (KeyTyped(KeyCode.RKey))
        {
            RestartAnimation(anim);
        }
    }
    else
    {
        DrawText("Animation Status: RUNNING", ColorGreen(), 300, 250);
        UpdateAnimation(anim);
    }

    DrawText("Press ESC to exit", ColorGray(), 320, 500);

    RefreshScreen(60);
}

// Free resources
FreeAnimation(anim);
FreeAnimationScript(script);

CloseAllWindows();
