using SplashKitSDK;
using static SplashKitSDK.SplashKit;

OpenWindow("Color Cycle Animation", 400, 400);

// Build a 4-frame sprite sheet in memory (each cell is 64x64)
SplashKitSDK.Bitmap sheet = CreateBitmap("sheet", 256, 64);
FillRectangleOnBitmap(sheet, ColorRed(), 0, 0, 64, 64);
FillRectangleOnBitmap(sheet, ColorGreen(), 64, 0, 64, 64);
FillRectangleOnBitmap(sheet, ColorBlue(), 128, 0, 64, 64);
FillRectangleOnBitmap(sheet, ColorYellow(), 192, 0, 64, 64);
BitmapSetCellDetails(sheet, 64, 64, 4, 1, 4);

// Load the animation script and create the animation
SplashKitSDK.AnimationScript script = LoadAnimationScript("color_cycle", "color_cycle.txt");
SplashKitSDK.Animation anim = CreateAnimation(script, "ColorCycle");

while (!QuitRequested())
{
    ProcessEvents();
    ClearScreen(ColorWhite());

    // Draw the current animation frame centered on the window
    DrawBitmap(sheet, 168, 168, OptionWithAnimation(anim));

    // Advance the animation to the next frame
    UpdateAnimation(anim);

    RefreshScreen(60);
}

// Release resources
FreeAnimation(anim);
FreeAnimationScript(script);
CloseAllWindows();
