using static SplashKitSDK.SplashKit;

OpenWindow("Load Animation Script", 800, 600);

// Load an animation script from file
var kermitScript = LoadAnimationScript("kermit", "kermit.txt");

// Check if the script was loaded successfully
if (HasAnimationScript("kermit"))
{
    ClearScreen(ColorWhite());
    DrawText("Animation Script Loaded Successfully!", ColorGreen(), 250, 280);
    DrawText("Script Name: kermit", ColorBlack(), 300, 320);
    DrawText($"Animation Count: {AnimationCount(kermitScript)}", ColorBlue(), 280, 360);
    RefreshScreen();
}

Delay(5000);

// Free the animation script when done
FreeAnimationScript(kermitScript);

CloseAllWindows();
