// I am scaling a bitmap at draw time with OptionScaleBmp.
// A makes smaller; D makes bigger; R resets; SPACE toggles outline; ESC quits.

using SplashKitSDK;
using static SplashKitSDK.SplashKit;

static Bitmap MakeSticker()
{
    int w = 128;
    int h = 128;
    Bitmap bmp = CreateBitmap("sticker", w, h);
    ClearBitmap(bmp, RGBAColor(255, 255, 255, 0)); // transparent

    for (int y = 0; y < h; y += 16)
    {
        DrawLineOnBitmap(bmp, RGBColor(220, 220, 220), 0, y, w, y);
    }
    for (int x = 0; x < w; x += 16)
    {
        DrawLineOnBitmap(bmp, RGBColor(220, 220, 220), x, 0, x, h);
    }

    FillCircleOnBitmap(bmp, RGBColor(33, 150, 243), w / 2, h / 2, 36);
    DrawCircleOnBitmap(bmp, ColorBlack(), w / 2, h / 2, 36);
    DrawRectangleOnBitmap(bmp, ColorBlack(), 1, 1, w - 2, h - 2);

    return bmp;
}

const int windowWidth = 800;
const int windowHeight = 480;
OpenWindow("Option Scale Bmp — live scaling", windowWidth, windowHeight);

Bitmap sticker = MakeSticker();

double scale = 1.0;
const double step = 0.1;
const double minScale = 0.2;
const double maxScale = 3.0;

bool showOutline = true;

double cx = windowWidth / 2.0;
double cy = windowHeight / 2.0;

while (!QuitRequested())
{
    ProcessEvents();

    if (KeyTyped(KeyCode.EscapeKey))
    {
        break;
    }
    if (KeyTyped(KeyCode.AKey))
    {
        scale = scale - step;
        if (scale < minScale)
        {
            scale = minScale;
        }
    }
    if (KeyTyped(KeyCode.DKey))
    {
        scale = scale + step;
        if (scale > maxScale)
        {
            scale = maxScale;
        }
    }
    if (KeyTyped(KeyCode.RKey))
    {
        scale = 1.0;
    }
    if (KeyTyped(KeyCode.SpaceKey))
    {
        showOutline = !showOutline;
    }

    ClearScreen(ColorWhite());

    double x = cx - BitmapWidth(sticker) / 2.0;
    double y = cy - BitmapHeight(sticker) / 2.0;
    DrawBitmap(sticker, x, y, OptionScaleBmp(scale, scale));

    if (showOutline)
    {
        double w = BitmapWidth(sticker) * scale;
        double h = BitmapHeight(sticker) * scale;
        DrawRectangle(ColorNavy(), cx - w / 2.0, cy - h / 2.0, w, h);
    }

    DrawText("A: smaller   D: bigger   R: reset   SPACE: outline   ESC: quit",
             RGBColor(0, 0, 128), 16, 16);

    DrawText("Scale: " + scale.ToString("0.0") + "×", ColorBlack(), 16, 40);

    RefreshScreen(60);
}

FreeBitmap(sticker);