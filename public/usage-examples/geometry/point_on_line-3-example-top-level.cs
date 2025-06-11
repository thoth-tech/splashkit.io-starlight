using SplashKitSDK;
using static SplashKitSDK.SplashKit;

// Create window
Window window = new Window("Hover to Guess the Hidden Point", 800, 600);

// Define the base line and hidden point
Line baseLine = LineFrom(PointAt(100, 300), PointAt(700, 300));
Point2D hiddenPoint = PointAt(Rnd(100, 700), 300);

while (!window.CloseRequested)
{
    // Process events and handle user input
    ProcessEvents();

    // Clear the screen
    ClearScreen(Color.White);

    // Draw the base line
    DrawLine(Color.Black, baseLine);

    // Get mouse position
    Point2D mouse = MousePosition();

    // Check if the mouse is close enough to the hidden point
    if (PointPointDistance(mouse, hiddenPoint) <= 8.0)
    {
        DrawCircle(Color.Blue, hiddenPoint.X, hiddenPoint.Y, 5);
        DrawText("You found the hidden point!", Color.Green, 260, 450);
    }
    else if (PointOnLine(mouse, baseLine, 5.0f))
    {
        DrawText("You're on the line, but not on the hidden point.", Color.Red, 180, 450);
    }
    else
    {
        DrawText("Move your mouse over the line to find the hidden point!", Color.Black, 150, 450);
    }

    // Refresh the window with the updated screen
    RefreshScreen(60);
}

// Close the window after the game ends
CloseWindow(window);
