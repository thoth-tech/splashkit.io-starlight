using static SplashKitSDK.SplashKit;

OpenWindow("Update Animation Example", 800, 600);

// Load animation script and create animation
var script = LoadAnimationScript("kermit", "kermit.txt");
var anim = CreateAnimation(script, "SplashKitOnlineDemo");

// Animation loop
while (!QuitRequested() && !AnimationEnded(anim))
{
    ProcessEvents();

    ClearScreen(ColorWhite());

    // Display current animation state
    DrawText("Update Animation Demo", ColorBlack(), 300, 100);
    DrawText($"Current Cell: {AnimationCurrentCell(anim)}", ColorBlue(), 300, 200);
    DrawText($"Frame Time: {AnimationFrameTime(anim)}", ColorGreen(), 300, 250);
    DrawText($"Animation Ended: {(AnimationEnded(anim) ? "Yes" : "No")}", ColorPurple(), 300, 300);
    DrawText("Press ESC to exit", ColorGray(), 320, 500);

    // Update the animation
    UpdateAnimation(anim);

    RefreshScreen(60);
}

// Free resources
FreeAnimation(anim);
FreeAnimationScript(script);

CloseAllWindows();
