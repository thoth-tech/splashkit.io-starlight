using static SplashKitSDK.SplashKit;
using SplashKitSDK;

// Open a window with a fixed title and size
OpenWindow("Circle Quad Intersect Example", 800, 600);

// Define the four corner points of the quad in clockwise order
Point2D topLeft = PointAt(300, 200);
Point2D topRight = PointAt(500, 200);
Point2D bottomRight = PointAt(500, 400);
Point2D bottomLeft = PointAt(300, 400);

// Create a quad using the four defined points
Quad fixedQuad = QuadFrom(topLeft, topRight, bottomRight, bottomLeft);

// Define a fixed radius for the mouse-following circle
float radius = 30;

// Main program loop — runs until the window is closed
while (!WindowCloseRequested("Circle Quad Intersect Example"))
{
    // Handle all events (keyboard, mouse, window)
    ProcessEvents();

    // Clear the screen with a dark background
    ClearScreen(Color.DarkSlateGray);

    // Get the current position of the mouse
    Point2D mouse = MousePosition();

    // Create a circle centered at the mouse position with the specified radius
    Circle mouseCircle = CircleAt(mouse.X, mouse.Y, radius);

    // Determine whether the circle intersects with the quad
    bool isIntersecting = CircleQuadIntersect(mouseCircle, fixedQuad);

    // Choose a fill color based on whether the intersection occurs
    Color fillColor = isIntersecting ? Color.Red : Color.Green;

    // Draw the quad using two filled triangles
    FillTriangle(fillColor,
        topLeft.X, topLeft.Y,
        topRight.X, topRight.Y,
        bottomRight.X, bottomRight.Y);

    FillTriangle(fillColor,
        topLeft.X, topLeft.Y,
        bottomLeft.X, bottomLeft.Y,
        bottomRight.X, bottomRight.Y);

    // Draw the circle outline in white
    DrawCircle(Color.White, mouseCircle);

    // Refresh the screen at 60 frames per second
    RefreshScreen(60);
}