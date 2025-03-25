using SplashKitSDK;
using static SplashKitSDK.SplashKit;

// Set the frame rate to 60 frames per second
const int fps = 60;

// Open a window with dimensions 800 x 600
Window window = OpenWindow("Usage Example - Option Rotate Bmp", 800, 600);

// Create a bitmap with dimensions 300 x 300
Bitmap bmp = CreateBitmap("box", 300, 300);

// Draw a red box on the bitmap
Quad rect = QuadFrom(0, 0, 300, 0, 0, 300, 300, 300);
FillQuadOnBitmap(bmp, Color.Red, rect);

// Initialize a double to hold the angle of the rotated bitmap
double angle = 0;

// Loop until the user exits
while (!WindowCloseRequested(window))
{
    // Poll for events caused by user interaction
    ProcessEvents();

    // Rotate the box 180 degrees every second
    angle += 360 / 2 / fps;

    // Create the draw options that will rotate the bitmap
    DrawingOptions opts = OptionRotateBmp(angle);

    // Clear the previous frame and set the background to black
    ClearWindow(window, Color.Black);

    // Draw the rotated bitmap at the center of the screen
    DrawBitmapOnWindow(window, bmp, 250, 150, opts);
    RefreshWindow(window, fps);
}

// Clean up by freeing any memory used by the window
CloseWindow(window);
