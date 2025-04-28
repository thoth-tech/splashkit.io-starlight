using SplashKitSDK;
using static SplashKitSDK.SplashKit;

// Access the first display
Display display = DisplayDetails(0);

// Set the refresh rate to 60 frames per second
const int fps = 60;

const int windowWidth = 800;
const int windowHeight = 600;

// Calculate the position of the first window
int windowPositionX = (DisplayWidth(display) - 2 * windowWidth) / 2;
int windowPositionY = (DisplayHeight(display) - windowHeight) / 2;

// Open two windows with black backgrounds
Window windowOne = OpenWindow("Window 1 - Draw Pixel On Window", windowWidth, windowHeight);
Window windowTwo = OpenWindow("Window 2 - Draw Pixel On Window", windowWidth, windowHeight);
ClearWindow(windowOne, Color.Black);
ClearWindow(windowTwo, Color.Black);

// Position the windows side by side in the middle of the display
MoveWindowTo(windowOne, windowPositionX, windowPositionY);
MoveWindowTo(windowTwo, windowPositionX + windowWidth, windowPositionY);

// Store the angle and radius of the spiral at any given time
double angle = 0.0;
double radius = 0.0;

const double maxRadius = windowWidth / 2;

// Coordinates for the center of the spiral
Point2D center = PointAt(windowWidth / 2, windowHeight / 2);

while (!WindowCloseRequested(windowOne) && !WindowCloseRequested(windowTwo))
{
    // Poll for user interaction
    ProcessEvents();

    // Stop drawing spiral once the width of the window is exceeded
    if (radius > maxRadius) continue;

    // Increment spiral radius so it will reach window width in 30 seconds
    radius += maxRadius / fps / 30;

    // Increment spiral angle so it will complete a revolution every 5 seconds
    angle += 360.0 / fps / 5;

    // Calculate the x and y coordinates of the pixel to be drawn
    double x = center.X + radius * Cosine((float)angle);
    double y = center.Y + radius * Sine((float)angle);

    // Draw the next pixel of the spiral on both windows
    DrawPixelOnWindow(windowOne, Color.Yellow, x, y);
    DrawPixelOnWindow(windowTwo, Color.Red, x, y);

    RefreshScreen(fps);
}

// Clean up any resources or memory used by the windows
CloseAllWindows();