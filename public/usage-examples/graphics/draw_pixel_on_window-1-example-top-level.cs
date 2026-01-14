using SplashKitSDK;
using static SplashKitSDK.SplashKit;

// Declare constants
const int FPS = 60;     // Set frame rate to 60 frames per second

const int WINDOW_WIDTH = 800;
const int WINDOW_HEIGHT = 600;

int WINDOW_X_POS = (DisplayWidth(DisplayDetails(0)) - 2 * WINDOW_WIDTH) / 2;
int WINDOW_Y_POS = (DisplayHeight(DisplayDetails(0)) - WINDOW_HEIGHT) / 2;

const double MAX_RADIUS = WINDOW_HEIGHT * 3.0 / 8;

// Declare variables
double angle = 0.0;
double radius = 0.0;

// Open two windows with black backgrounds and position them side by side at center screen
Window windowLeft = OpenWindow("Left Window - Pink Spiral", WINDOW_WIDTH, WINDOW_HEIGHT);
Window windowRight = OpenWindow("Right Window - Blue Spiral", WINDOW_WIDTH, WINDOW_HEIGHT);

ClearWindow(windowLeft, ColorBlack());
ClearWindow(windowRight, ColorBlack());

MoveWindowTo(windowLeft, WINDOW_X_POS, WINDOW_Y_POS);
MoveWindowTo(windowRight, WINDOW_X_POS + WINDOW_WIDTH, WINDOW_Y_POS);

while (!WindowCloseRequested(windowLeft) && !WindowCloseRequested(windowRight))
{
    ProcessEvents();

    // Stop drawing when max radius is exceeded
    if (radius > MAX_RADIUS)
    {
        continue;
    }

    // Increment the radius and angle of the next pixel, and calculate the x-y coordinates
    radius += MAX_RADIUS / FPS / 60;
    angle += 360.0 / FPS / 15;

    double x = WINDOW_WIDTH / 2 + radius * Cosine((float)angle);
    double y = WINDOW_HEIGHT / 2 + radius * Sine((float)angle);

    // Draw the pixel on each window and refresh
    DrawPixelOnWindow(windowLeft, ColorHotPink(), x, y);
    DrawPixelOnWindow(windowRight, ColorCyan(), x, y);
    RefreshScreen(FPS);
}

// Clean up
CloseAllWindows();