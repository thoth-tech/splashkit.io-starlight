using static SplashKitSDK.SplashKit;
using SplashKitSDK;

// Create a window and bitmap for the window
Window window = OpenWindow("Window", 400, 300);
Bitmap bitmap = CreateBitmap("window", 400, 300);

// Fill background with white
ClearBitmap(bitmap, ColorWhite());

// Create color
Color color = RGBAColor(100, 150, 255, 128);

// Size and spacing for squares
double size = 80;
double gap = 10;
double start_x = 110;
double start_y = 60;

// Draw the four Window panels
Quad[] panels = {
    QuadFrom(
        start_x, start_y,
        start_x + size, start_y,
        start_x, start_y + size,
        start_x + size, start_y + size
    ),
    QuadFrom(
        start_x + size + gap, start_y,
        start_x + size*2 + gap, start_y,
        start_x + size + gap, start_y + size,
        start_x + size*2 + gap, start_y + size
    ),
    QuadFrom(
        start_x, start_y + size + gap,
        start_x + size, start_y + size + gap,
        start_x, start_y + size*2 + gap,
        start_x + size, start_y + size*2 + gap
    ),
    QuadFrom(
        start_x + size + gap, start_y + size + gap,
        start_x + size*2 + gap, start_y + size + gap,
        start_x + size + gap, start_y + size*2 + gap,
        start_x + size*2 + gap, start_y + size*2 + gap
    )
};

// Draw each panel
for (int i = 0; i < panels.Length; i++)
{
    FillQuadOnBitmap(bitmap, color, panels[i]);
}

while (!window.CloseRequested)
{
    ProcessEvents();
    // Draw the bitmap to the window
    DrawBitmap(bitmap, 0, 0);
    // Refresh the window
    RefreshScreen();
}

FreeBitmap(bitmap);