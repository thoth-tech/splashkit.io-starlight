using static SplashKitSDK.SplashKit;

OpenWindow("Animation Frame Time Example", 800, 600);

// Load animation script and create animation
var script = LoadAnimationScript("explosion", "explosion.txt");
var anim = CreateAnimation(script, "Explosion");

while (!QuitRequested())
{
    ProcessEvents();

    ClearScreen(ColorWhite());

    // Display animation frame time
    DrawText("Animation Frame Time Example", ColorBlack(), 270, 100);
    DrawText($"Current Cell: {AnimationCurrentCell(anim)}", ColorBlue(), 300, 200);

    // Get and display frame time using animation_frame_time
    float frameTime = AnimationFrameTime(anim);
    DrawText($"Frame Time: {frameTime} ms", ColorGreen(), 300, 250);

    // Display instructions
    DrawText("Frame time shows how long this frame lasts", ColorPurple(), 230, 350);
    DrawText("Press R to restart animation", ColorOrange(), 280, 450);
    DrawText("Press ESC to exit", ColorGray(), 320, 500);

    if (KeyTyped(KeyCode.RKey))
    {
        RestartAnimation(anim);
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
