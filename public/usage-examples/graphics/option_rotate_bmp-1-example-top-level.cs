using SplashKitSDK;
using static SplashKitSDK.SplashKit;

// Set the frame rate to 60 frames per second
const int fps = 60;

// Open a window with dimensions 800 x 600
OpenWindow("Usage Example - Option Rotate Bmp", 800, 600);

// Create a bitmap with dimensions 300 x 300
Bitmap bmp = CreateBitmap("box", 300, 300);

// Draw a red box on the bitmap
Quad rect = QuadFrom(0, 0, 300, 0, 0, 300, 300, 300);
FillQuadOnBitmap(bmp, Color.Red, rect);

// Initialize a float to hold the angle of the rotated bitmap
float angle = 0;

// Loop until the user exits
while (!QuitRequested())
{
    // Poll for events caused by user interaction
    ProcessEvents();

    // Increment the angle of the box for the current frame.
    // This calculation will rotate the box 180 degrees every second.
    angle += 360 / 2 / fps;

    // Keep the angle between 0 and 360 degrees
    if (angle >= 360) angle -= 360;

    // Create the draw options that will rotate the bitmap
    DrawingOptions opts = OptionRotateBmp(angle);

    // Clear the previous frame and set the background to black
    ClearScreen(Color.Black);

    // Draw the rotated bitmap at the center of the screen
    DrawBitmap(bmp, 250, 150, opts);

    // Refresh the screen to show the current frame.
    // Since the fps is 60, this will happen 60 times per second.
    RefreshScreen(fps);
}

// Clean up by freeing any memory used by the windows
CloseAllWindows();
