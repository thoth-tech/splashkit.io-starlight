using SplashKitSDK; // Required import for using SplashKit functions and types

// Entry point of the program
public class Program
{
    public static void Main()
    {
        // Create and run the application
        new CircleQuadIntersectApp().Run();
    }
}

// This class contains the logic for checking and displaying intersection between a circle and a quad
public class CircleQuadIntersectApp
{
    // Window and geometric variables
    private Window window;
    private Point2D p1, p2, p3, p4;
    private Quad fixedQuad;
    private float radius = 30;

    // Constructor: sets up the window and quad
    public CircleQuadIntersectApp()
    {
        // Create a new window with a title and fixed dimensions
        window = new Window("Circle Quad Intersect Example", 800, 600);

        // Define the quad using four corner points
        SetupQuad();
    }

    // Set up four corner points and construct the quad from them
    private void SetupQuad()
    {
        // Define each point of the quad in clockwise order
        p1 = SplashKit.PointAt(300, 200); // Top-left
        p2 = SplashKit.PointAt(500, 200); // Top-right
        p3 = SplashKit.PointAt(500, 400); // Bottom-right
        p4 = SplashKit.PointAt(300, 400); // Bottom-left

        // Create a quad using the four points
        fixedQuad = SplashKit.QuadFrom(p1, p2, p3, p4);
    }

    // Main application loop
    public void Run()
    {
        while (!window.CloseRequested)
        {
            // Handle system and user input events
            SplashKit.ProcessEvents();

            // Clear the screen with a dark background color
            SplashKit.ClearScreen(Color.DarkSlateGray);

            // Get the current position of the mouse
            Point2D mouse = SplashKit.MousePosition();

            // Create a circle centered on the mouse with a fixed radius
            Circle mouseCircle = SplashKit.CircleAt(mouse.X, mouse.Y, radius);

            // Check whether the mouse-following circle intersects with the quad
            bool isIntersecting = SplashKit.CircleQuadIntersect(mouseCircle, fixedQuad);

            // Choose fill color based on intersection state (Red if true, Green if false)
            Color fillColor = isIntersecting ? Color.Red : Color.Green;

            // Fill the quad as two triangles to ensure compatibility with rendering
            SplashKit.FillTriangle(fillColor, p1.X, p1.Y, p2.X, p2.Y, p3.X, p3.Y);
            SplashKit.FillTriangle(fillColor, p1.X, p1.Y, p4.X, p4.Y, p3.X, p3.Y);

            // Draw the circle outline following the mouse
            SplashKit.DrawCircle(Color.White, mouseCircle);

            // Refresh the screen to display updated graphics
            SplashKit.RefreshScreen(60);
        }
    }
}