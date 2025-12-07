using static SplashKitSDK.SplashKit;

OpenWindow("Animation Entered Frame Example", 800, 600);

// Load animation script and create animation
var script = LoadAnimationScript("kermit", "kermit.txt");
var anim = CreateAnimation(script, "SplashKitOnlineDemo");

int frameEnterCount = 0;

while (!QuitRequested())
{
    ProcessEvents();

    ClearScreen(ColorWhite());

    // Display animation state
    DrawText("Animation Entered Frame Example", ColorBlack(), 260, 100);
    DrawText($"Current Cell: {AnimationCurrentCell(anim)}", ColorBlue(), 300, 200);

    // Check if animation entered a new frame using animation_entered_frame
    if (AnimationEnteredFrame(anim))
    {
        frameEnterCount++;
        DrawText("Just entered NEW FRAME!", ColorGreen(), 290, 280);
    }
    else
    {
        DrawText("Same frame as before", ColorGray(), 310, 280);
    }

    DrawText($"Frame Entry Count: {frameEnterCount}", ColorPurple(), 300, 340);

    // Display instructions
    DrawText("Press R to restart animation", ColorOrange(), 280, 450);
    DrawText("Press ESC to exit", ColorGray(), 320, 500);

    if (KeyTyped(KeyCode.RKey))
    {
        RestartAnimation(anim);
        frameEnterCount = 0;
    }

    // Only update if animation hasn't ended
    if (!AnimationEnded(anim))
    {
        UpdateAnimation(anim);
    }

    RefreshScreen(60);
}

// Free resources
FreeAnimation(anim);
FreeAnimationScript(script);

CloseAllWindows();
