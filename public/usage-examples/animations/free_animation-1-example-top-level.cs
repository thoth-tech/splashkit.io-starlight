using static SplashKitSDK.SplashKit;

OpenWindow("Free Animation Example", 800, 600);

// Load animation script
var script = LoadAnimationScript("explosion", "explosion.txt");

// Create animation
var anim = CreateAnimation(script, "Explosion");
bool animationExists = true;

while (!QuitRequested())
{
    ProcessEvents();

    ClearScreen(ColorWhite());

    // Display instructions
    DrawText("Free Animation Demo", ColorBlack(), 300, 100);

    if (animationExists)
    {
        DrawText($"Current Cell: {AnimationCurrentCell(anim)}", ColorBlue(), 300, 200);
        DrawText("Animation Status: Active", ColorGreen(), 300, 250);
        DrawText("Press F to FREE the animation", ColorOrange(), 270, 400);

        UpdateAnimation(anim);
    }
    else
    {
        DrawText("Animation Status: Freed", ColorRed(), 300, 250);
        DrawText("Press C to CREATE new animation", ColorOrange(), 260, 400);
    }

    DrawText("Press ESC to exit", ColorGray(), 320, 500);

    // Free animation when F is pressed
    if (KeyTyped(KeyCode.FKey) && animationExists)
    {
        FreeAnimation(anim);
        animationExists = false;
    }

    // Create new animation when C is pressed
    if (KeyTyped(KeyCode.CKey) && !animationExists)
    {
        anim = CreateAnimation(script, "Explosion");
        animationExists = true;
    }

    RefreshScreen(60);
}

// Final cleanup
if (animationExists)
{
    FreeAnimation(anim);
}
FreeAnimationScript(script);

CloseAllWindows();
