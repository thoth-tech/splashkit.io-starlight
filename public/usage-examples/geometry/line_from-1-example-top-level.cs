using SplashKitSDK;
using System;
using System.Collections.Generic;

List<Line> lines = new List<Line>();  // List to store lines drawn by the user
int lineStartX = 0, lineStartY = 0;    // Start coordinates of the current line
bool lineStarted = false;              // Flag to track if a line has started

// Open the window for drawing lines
SplashKit.OpenWindow("Creating Lines With Mouse Input", 800, 600);

// Main loop: runs until the program is quit
while (!SplashKit.WindowCloseRequested("Creating Lines With Mouse Input") && !SplashKit.KeyDown(KeyCode.EscapeKey))
{
    SplashKit.ProcessEvents();  // Process user input events like mouse clicks

    // Check if the left mouse button was clicked
    if (SplashKit.MouseClicked(MouseButton.LeftButton))
    {
        HandleMouseClick();
    }

    SplashKit.ClearScreen();  // Clear the screen to redraw everything

    // If the line has started, draw a temporary line from the start to current mouse position
    if (lineStarted)
    {
        SplashKit.DrawLine(Color.Red, lineStartX, lineStartY, (int)SplashKit.MouseX(), (int)SplashKit.MouseY());
    }

    // Loop through the lines list and draw each saved line
    foreach (var line in lines)
    {
        SplashKit.DrawLine(Color.Blue, line);
    }

    // Display a message at the top of the screen
    SplashKit.DrawText("Click anywhere to start a line", Color.Black, 50, 50);

    SplashKit.RefreshScreen();  // Refresh the screen to show the updated drawing
}

// Handle mouse click to set start or end of the line
void HandleMouseClick()
{
    if (!lineStarted)
    {
        // If the line hasn't been started, store the start point
        lineStartX = (int)SplashKit.MouseX();
        lineStartY = (int)SplashKit.MouseY();
        lineStarted = true;  // Mark that the line has started
    }
    else
    {
        // If the line has started, store the end point and create the line
        int lineEndX = (int)SplashKit.MouseX();
        int lineEndY = (int)SplashKit.MouseY();

        // Create a new line using the start and end points
        Line newLine = SplashKit.LineFrom(lineStartX, lineStartY, lineEndX, lineEndY);

        // Add the created line to the lines list
        lines.Add(newLine);
        lineStarted = false;  // Reset the flag to allow starting a new line
    }
}