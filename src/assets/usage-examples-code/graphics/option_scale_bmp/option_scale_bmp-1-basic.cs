// I am scaling a bitmap at draw time with OptionScaleBmp.
// I am pressing A to make smaller; I am pressing D to make bigger; I am pressing R to reset;
// I am pressing SPACE to toggle outline; I am pressing ESC to quit.

using SplashKitSDK;
using static SplashKitSDK.SplashKit;

static Bitmap MakeStickerBitmap()
{
    // I am creating a small procedural bitmap so no external file is needed.
    int stickerWidth = 128;
    int stickerHeight = 128;
    Bitmap bmp = CreateBitmap("sticker", stickerWidth, stickerHeight);
    ClearBitmap(bmp, RGBAColor(255, 255, 255, 0)); // I am making the background transparent.

    // I am drawing a light grid to show scale changes.
    for (int y = 0; y < stickerHeight; y += 16)
    {
        DrawLineOnBitmap(bmp, RGBColor(220, 220, 220), 0, y, stickerWidth, y);
    }
    for (int x = 0; x < stickerWidth; x += 16)
    {
        DrawLineOnBitmap(bmp, RGBColor(220, 220, 220), x, 0, x, stickerHeight);
    }

    // I am drawing a circle and a border so the sticker is easy to see.
    FillCircleOnBitmap(bmp, RGBColor(33, 150, 243), stickerWidth / 2, stickerHeight / 2, 36);
    DrawCircleOnBitmap(bmp, ColorBlack(), stickerWidth / 2, stickerHeight / 2, 36);
    DrawRectangleOnBitmap(bmp, ColorBlack(), 1, 1, stickerWidth - 2, stickerHeight - 2);

    return bmp;
}

// I am opening the window with a short title; I am drawing instructions inside the window.
OpenWindow("Option Scale Bmp - live", 800, 480);

// I am building the sticker once and I am reusing it each frame.
Bitmap stickerBitmap = MakeStickerBitmap();

// I am tracking the current scale and the valid range.
double currentScale = 1.0;
const double scaleStep = 0.1;
const double minScale = 0.2;
const double maxScale = 3.0;

// I am toggling an outline so the scaled bounds are obvious.
bool showOutline = true;

// I am centering my drawing around the window middle.
double centerX = 800 / 2.0;
double centerY = 480 / 2.0;

while (!QuitRequested())
{
    ProcessEvents();

    // I am handling the controls.
    if (KeyTyped(KeyCode.EscapeKey))
    {
        break;
    }
    if (KeyTyped(KeyCode.AKey))
    {
        currentScale = currentScale - scaleStep;
        if (currentScale < minScale)
        {
            currentScale = minScale;
        }
    }
    if (KeyTyped(KeyCode.DKey))
    {
        currentScale = currentScale + scaleStep;
        if (currentScale > maxScale)
        {
            currentScale = maxScale;
        }
    }
    if (KeyTyped(KeyCode.RKey))
    {
        currentScale = 1.0;
    }
    if (KeyTyped(KeyCode.SpaceKey))
    {
        showOutline = !showOutline;
    }

    // I am clearing the frame to white.
    ClearScreen(ColorWhite());

    // I am drawing the sticker centered with the current scale applied.
    double drawX = centerX - BitmapWidth(stickerBitmap) / 2.0;
    double drawY = centerY - BitmapHeight(stickerBitmap) / 2.0;
    DrawBitmap(stickerBitmap, drawX, drawY, OptionScaleBmp(currentScale, currentScale));

    // I am drawing an outline that matches the scaled size.
    if (showOutline)
    {
        double outlineWidth  = BitmapWidth(stickerBitmap)  * currentScale;
        double outlineHeight = BitmapHeight(stickerBitmap) * currentScale;
        DrawRectangle(ColorNavy(),
                      centerX - outlineWidth / 2.0,
                      centerY - outlineHeight / 2.0,
                      outlineWidth,
                      outlineHeight);
    }

    // I am drawing the UI hints.
    DrawText("A: smaller   D: bigger   R: reset   SPACE: outline   ESC: quit",
             RGBColor(0, 0, 128), 16, 16);
    DrawText($"Scale: {currentScale:0.0} x", ColorBlack(), 16, 40);

    RefreshScreen(60);
}

// I am freeing the bitmap before I quit.
FreeBitmap(stickerBitmap);