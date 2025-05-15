using static SplashKitSDK.SplashKit;
using SplashKitSDK;
using System.Collections.Generic;   // Required for using List<T> for edges and colors

// Open a graphical window titled "Lines From Rectangle Example" with size 800x600
OpenWindow("Lines From Rectangle Example", 800, 600);

// Create a rectangle located at (250, 200) with width 300 and height 200
// This rectangle will be used to extract and display its 4 edge lines
Rectangle myRectangle = RectangleFrom(250, 200, 300, 200);

// Get the 4 edges (top, right, bottom, left) of the rectangle as a list of Line objects
List<Line> rectangleEdges = LinesFrom(myRectangle);

// Define a list of normal (default) colors for the 4 edges
// These colors are used when the mouse is not hovering over a particular edge
List<Color> normalColors = new List<Color>
{
    Color.Red,        // Top edge
    Color.LimeGreen,  // Right edge
    Color.Blue,       // Bottom edge
    Color.Orange      // Left edge
};

// Define a list of hover colors (white) for all 4 edges
// When the mouse hovers over an edge, it will be drawn in white
List<Color> hoverColors = new List<Color>
{
    Color.White,
    Color.White,
    Color.White,
    Color.White
};

// Main loop: runs continuously until the window is closed
while (!WindowCloseRequested("Lines From Rectangle Example"))
{
    // Handle input events (e.g., mouse movement, clicks, keypresses)
    ProcessEvents();

    // Set the background color to dark slate gray before drawing
    ClearScreen(Color.DarkSlateGray);

    // Fill the rectangle with black so the edges appear drawn on top of it
    FillRectangle(Color.Black, myRectangle.X, myRectangle.Y, myRectangle.Width, myRectangle.Height);

    // Get the current position of the mouse on the screen
    Point2D mousePosition = MousePosition();

    // Loop through each edge of the rectangle
    for (int i = 0; i < rectangleEdges.Count; i++)
    {
        Line edge = rectangleEdges[i];

        // If the mouse is currently hovering over this edge...
        if (PointOnLine(mousePosition, edge))
        {
            // Draw the edge using the hover color (white)
            DrawLine(
                hoverColors[i],
                edge.StartPoint.X, edge.StartPoint.Y,
                edge.EndPoint.X, edge.EndPoint.Y
            );
        }
        else
        {
            // Otherwise, draw the edge using the normal default color
            DrawLine(
                normalColors[i],
                edge.StartPoint.X, edge.StartPoint.Y,
                edge.EndPoint.X, edge.EndPoint.Y
            );
        }
    }

    // Refresh the screen to show all the newly drawn elements (frame rate: 60 FPS)
    RefreshScreen(60);
}