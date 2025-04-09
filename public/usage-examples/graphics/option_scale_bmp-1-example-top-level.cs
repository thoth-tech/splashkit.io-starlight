using SplashKitSDK;
using static SplashKitSDK.SplashKit;

// Set frame rate to 60 frames per second
const int fps = 60;

// Create a window with dimensions 800 x 600
Window window = OpenWindow("Usage Example - Option Scale Bitmap", 800, 600);

// Create a bitmap called 'ring' with dimensions 600 x 600
Bitmap bmp = CreateBitmap("ring", 600, 600);

// Paint the bitmap background black
ClearBitmap(bmp, Color.Black);

// Draw a ring on the bitmap
FillCircleOnBitmap(bmp, Color.White, 300, 300, 300);
FillCircleOnBitmap(bmp, Color.Black, 300, 300, 200);

// Initialize the time to 0
double time = 0;

// Loop until the user closes the window
while (!WindowCloseRequested(window))
{
    // Poll for user interactions
    ProcessEvents();

    // Increment the time by the duration of a frame
    time += 1.0 / fps;

    // Calculate the scale factor by squaring the time
    double scaleFactor = time * time;

    // If the bitmap is over 2.5 times its initial size, then reset the time
    if (scaleFactor > 2.5) time = 0;

    // Create the draw options that will scale the bitmap
    DrawingOptions opts = OptionScaleBmp(scaleFactor, scaleFactor);

    // Draw the scaled bitmap onto the window and refresh
    ClearWindow(window, Color.Black);
    DrawBitmapOnWindow(window, bmp, 100, 0, opts);
    RefreshWindow(window, fps);
}

// Clean up any memory or resources being used by the window
CloseWindow(window);
