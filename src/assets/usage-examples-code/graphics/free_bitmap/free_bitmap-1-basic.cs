// I am demonstrating creating, animating, and freeing a bitmap with a new color each load.
// L loads (creates) the bitmap in a random color; F frees it; ESC quits.

using SplashKitSDK;
using static SplashKitSDK.SplashKit;

const int windowWidth = 720;
const int windowHeight = 405;
OpenWindow("Free Bitmap - load, animate, free", windowWidth, windowHeight);

Bitmap? demo = null;
bool loaded = false;
int loadCount = 0;
double t = 0.0;

Color RandomColor()
{
    // I am forcing the (byte,byte,byte) overload to avoid unimplemented variants
    return RGBColor((byte)Rnd(0, 255), (byte)Rnd(0, 255), (byte)Rnd(0, 255));
}

void MakeDemo()
{
    demo = CreateBitmap("demo_bmp", 96, 96);

    var c = RandomColor();
    FillRectangleOnBitmap(demo, c, 0, 0, 96, 96);
    DrawRectangleOnBitmap(demo, ColorBlack(), 0, 0, 96, 96);

    loaded = true;
    loadCount = loadCount + 1;
}

while (!QuitRequested())
{
    ProcessEvents();

    if (KeyTyped(KeyCode.EscapeKey))
    {
        break;
    }
    if (KeyTyped(KeyCode.LKey))
    {
        if (loaded && demo != null)
        {
            FreeBitmap(demo);
            loaded = false;
            demo = null;
        }
        MakeDemo();
    }
    if (KeyTyped(KeyCode.FKey))
    {
        if (loaded && demo != null)
        {
            FreeBitmap(demo);
            loaded = false;
            demo = null;
        }
    }

    ClearScreen(ColorWhite());

    if (loaded && demo != null)
    {
        // I am animating with a gentle vertical bob
        t = t + 0.06;
        int cx = windowWidth / 2 - 48;
        int cy = windowHeight / 2 - 48 + (int)(8.0 * System.Math.Sin(t));

        DrawText("Status: Loaded  |  L: load  F: free  ESC: quit", ColorBlack(), 16, 16);
        DrawText($"Loads: {loadCount}", ColorBlack(), windowWidth - 110, 16);

        DrawBitmap(demo, cx, cy);
    }
    else
    {
        DrawText("Status: Freed  |  L: load  F: free  ESC: quit", ColorBlack(), 16, 16);
        DrawRectangle(RGBColor(128, 128, 128), windowWidth / 2 - 48, windowHeight / 2 - 48, 96, 96);
        DrawText("Freed", RGBColor(128, 128, 128), windowWidth / 2 - 20, windowHeight / 2 - 8);
    }

    RefreshScreen(60);
}

if (loaded && demo != null)
{
    FreeBitmap(demo);
}