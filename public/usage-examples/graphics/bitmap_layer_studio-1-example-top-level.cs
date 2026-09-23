using SplashKitSDK;
using static SplashKitSDK.SplashKit;

OpenWindow("Bitmap Layer Studio", 960, 540);

// Scene setup: open window and load four bitmap layers.
Bitmap backgroundLayer = LoadBitmap("background_layer", "layer_background.png");
Bitmap midLayer = LoadBitmap("mid_layer", "layer_midground.png");
Bitmap propsLayer = LoadBitmap("props_layer", "layer_props.png");
Bitmap foregroundLayer = LoadBitmap("foreground_layer", "layer_foreground.png");

double alpha = 0.45;
int bgRed = 48;
int bgGreen = 88;
int bgBlue = 128;
int fgRed = 250;
int fgGreen = 216;
int fgBlue = 126;

// Formula layer: C_out = alpha * C_fg + (1 - alpha) * C_bg.
int outRed = (int)(alpha * fgRed + (1.0 - alpha) * bgRed);
int outGreen = (int)(alpha * fgGreen + (1.0 - alpha) * bgGreen);
int outBlue = (int)(alpha * fgBlue + (1.0 - alpha) * bgBlue);
Color blendGuide = RGBAColor(outRed, outGreen, outBlue, 255);
Color overlayGuide = RGBAColor(fgRed, fgGreen, fgBlue, (int)(alpha * 255));

while (!QuitRequested())
{
    ProcessEvents();
    ClearScreen();

    // Layer pipeline: draw bitmaps back-to-front for stable compositing.
    DrawBitmap(backgroundLayer, 0, 0);
    DrawBitmap(midLayer, 0, 0);
    DrawBitmap(propsLayer, 0, 0);
    DrawBitmap(foregroundLayer, 0, 0);

    // Visual pass: draw depth guides and decorative perspective lines.
    DrawLine(blendGuide, 0, 370, 960, 370);
    DrawLine(overlayGuide, 480, 120, 180, 520);
    DrawLine(overlayGuide, 480, 120, 780, 520);
    DrawLine(blendGuide, 120, 500, 840, 500);

    RefreshScreen(60);
}

FreeAllBitmaps();
CloseAllWindows();
