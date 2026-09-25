using SplashKitSDK;
using static SplashKitSDK.SplashKit;

OpenWindow("Bitmap Canvas", 800, 600);

Bitmap canvas = CreateBitmap("canvas", 500, 300);

ClearBitmap(canvas, ColorWhite());

DrawRectangleOnBitmap(canvas, ColorRed(), 20, 20, 120, 80);
DrawRectangleOnBitmap(canvas, ColorBlue(), 170, 50, 150, 100);
DrawRectangleOnBitmap(canvas, ColorGreen(), 360, 30, 100, 200);

while (!QuitRequested())
{
    ProcessEvents();
    ClearScreen(ColorLightGray());

    DrawText(
        "These rectangles were drawn onto a bitmap first.",
        ColorBlack(),
        20,
        20
    );

    DrawText(
        "The bitmap is then drawn to the window.",
        ColorBlack(),
        20,
        50
    );

    DrawBitmap(canvas, 150, 180);

    RefreshScreen(60);
}

CloseAllWindows();
