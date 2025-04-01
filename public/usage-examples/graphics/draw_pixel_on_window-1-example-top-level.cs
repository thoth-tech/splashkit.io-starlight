using SplashKitSDK;
using static SplashKitSDK.SplashKit;

// Sets the refresh rate at 60 frames per second
const int fps = 60;

const int width = 800;
const int height = 600;

// Create a window and make the background black
Window window = OpenWindow("Usage Example - Draw Pixel On Window", width, height);
ClearWindow(window, Color.Black);

// Variables for the angle and radius of the spiral at any given time
double angle = 0.0;
double radius = 0.0;

const double max_radius = width / 2;
Point2D center = PointAt(width / 2, height / 2);

while (!WindowCloseRequested(window))
{
    // Poll for user interaction
    ProcessEvents();
    
    // Stop drawing spiral once the width of the window is exceeded
    if (radius > max_radius) continue;
    
    // Increment spiral radius so it will reach window width in 30 seconds
    radius += max_radius / fps / 30;
    
    // Increment spiral angle so it will complete a cycle every 5 seconds
    angle += 360.0 / fps / 5;
    
    // Calculate the x and y coordinates of the pixel to be drawn
    double x = center.X + radius * Cosine((float)angle);
    double y = center.Y + radius * Sine((float)angle);

    // Draws the next pixel of the spiral on the window
    DrawPixelOnWindow(window, Color.Yellow, x, y);
    RefreshWindow(window, fps);
}

// Clean up any resources or memory used by the window
CloseWindow(window);