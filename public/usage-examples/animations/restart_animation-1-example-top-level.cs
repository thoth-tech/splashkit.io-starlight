using static SplashKitSDK.SplashKit;

OpenWindow("Restart Animation Example", 800, 600);

// Load animation script and create animation
var script = LoadAnimationScript("explosion", "explosion.txt");
var anim = CreateAnimation(script, "Explosion");

int restartCount = 0;

while (!QuitRequested())
{
    ProcessEvents();

    ClearScreen(ColorWhite());

    // Display animation state
    DrawText("Restart Animation Demo", ColorBlack(), 300, 100);
    DrawText($"Current Cell: {AnimationCurrentCell(anim)}", ColorBlue(), 300, 200);
    DrawText($"Restart Count: {restartCount}", ColorGreen(), 300, 250);
    DrawText($"Animation Ended: {(AnimationEnded(anim) ? "Yes" : "No")}", ColorPurple(), 300, 300);
    DrawText("Press SPACE to restart animation", ColorOrange(), 250, 400);
    DrawText("Press ESC to exit", ColorGray(), 320, 500);

    // Restart animation when space is pressed
    if (KeyTyped(KeyCode.SpaceKey))
    {
        RestartAnimation(anim);
        restartCount++;
    }

    UpdateAnimation(anim);
    RefreshScreen(60);
}

// Free resources
FreeAnimation(anim);
FreeAnimationScript(script);

CloseAllWindows();
