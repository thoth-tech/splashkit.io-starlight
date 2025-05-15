using SplashKitSDK;

// Entry point class for the program
public class Program
{
    public static void Main()
    {
        // Create a new instance of the app and run it
        RectangleLinesApp app = new RectangleLinesApp();
        app.Run();
    }
}

// This class contains the logic for displaying a rectangle and interacting with its edges
public class RectangleLinesApp
{
    // Declare required variables
    private Window window;
    private Rectangle myRectangle;
    private List<Line> rectangleEdges;
    private List<Color> normalColors;
    private List<Color> hoverColors;

    // Main method to run the application
    public void Run()
    {
        // Create a graphical window for rendering
        window = new Window("Lines From Rectangle Example", 800, 600);

        // Define a rectangle at a fixed position (centered manually)
        myRectangle = SplashKit.RectangleFrom(250, 200, 300, 200);

        // Get the four edges of the rectangle as separate line objects
        rectangleEdges = SplashKit.LinesFrom(myRectangle);

        // Define the default colors for each edge of the rectangle
        normalColors = new List<Color> 
        { 
            Color.Red, 
            Color.LimeGreen, 
            Color.Blue, 
            Color.Orange 
        };

        // Define the hover colors (white for all edges when mouse is over)
        hoverColors = new List<Color> 
        { 
            Color.White, 
            Color.White, 
            Color.White, 
            Color.White 
        };

        // Main game loop — runs until the user closes the window
        while (!window.CloseRequested)
        {
            // Handle keyboard and mouse input events
            SplashKit.ProcessEvents();

            // Set background color
            SplashKit.ClearScreen(Color.DarkSlateGray);

            // Draw a black-filled rectangle as the base shape
            SplashKit.FillRectangle(
                Color.Black, 
                myRectangle.X, 
                myRectangle.Y, 
                myRectangle.Width, 
                myRectangle.Height
            );

            // Get the current mouse position
            Point2D mousePosition = SplashKit.MousePosition();

            // Loop through each edge of the rectangle
            for (int i = 0; i < rectangleEdges.Count; i++)
            {
                Line edge = rectangleEdges[i];

                // If the mouse is currently hovering over this edge
                if (SplashKit.PointOnLine(mousePosition, edge))
                {
                    // Draw the edge using the hover color (white)
                    DrawLineManually(hoverColors[i], edge);
                }
                else
                {
                    // Otherwise, draw the edge using the default color
                    SplashKit.DrawLine(normalColors[i], edge);
                }
            }

            // Refresh the screen at 60 frames per second
            SplashKit.RefreshScreen(60);
        }
    }

    // Draw a line by specifying start and end coordinates manually
    // This avoids using overloaded methods which may confuse beginners
    private void DrawLineManually(Color color, Line edge)
    {
        SplashKit.DrawLine(
            color,
            edge.StartPoint.X, edge.StartPoint.Y,
            edge.EndPoint.X, edge.EndPoint.Y
        );
    }
}