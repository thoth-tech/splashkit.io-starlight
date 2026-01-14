using SplashKitSDK;
using static SplashKitSDK.SplashKit;

// Declare Variables
Circle ball;
// -80 to account for title bar and task bar
int height = DisplayHeight(DisplayDetails(0)) - 80;
double acceleration = 0.8;
double damping = 0.5;
double velocity = 0;
double ballY = 0;
int radius = 50;

// Open window with the height of the display
OpenWindow("Bouncing Ball", 800, height);

while (!QuitRequested())
{
    ClearScreen(ColorWhite());

    DrawText($"Display Height: {DisplayHeight(DisplayDetails(0))} Pixels", ColorBlack(), 25, 25);
    // Set ball details and draw
    ball = CircleAt(400, ballY, radius);
    FillCircle(ColorBlue(), ball);

    // Set acceleration and velocity for ball
    ballY += velocity;
    velocity += acceleration;

    // Check if ball has hit bottom of window to trigger bounce
    if (ballY + radius >= height)
    {
        // Keep ball in window
        ballY = height - radius;
        // Reverse velocity and apply damping
        velocity = -velocity * damping;
        // Halt velocity to stop ball bouncing 
        if (Math.Abs(velocity) < 3)
        {
            velocity = 0;
        }
    }
    RefreshScreen(60);
    ProcessEvents();
}
CloseAllWindows();