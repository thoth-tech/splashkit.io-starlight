using static SplashKitSDK.SplashKit;
using SplashKitSDK;

// Create window
OpenWindow("Circle Quad Intersect Example", 800, 600);

// Define 4 points (clockwise order)
Point2D p1 = PointAt(300, 200); // top-left
Point2D p2 = PointAt(500, 200); // top-right
Point2D p3 = PointAt(500, 400); // bottom-right
Point2D p4 = PointAt(300, 400); // bottom-left

// Create quad using the points
Quad fixedQuad = QuadFrom(p1, p2, p3, p4);

float radius = 30;

while (!WindowCloseRequested("Circle Quad Intersect Example"))
{
    ProcessEvents();
    ClearScreen(Color.DarkSlateGray);

    // Create circle following the mouse
    Point2D pos = MousePosition();
    Circle mouseCircle = CircleAt(pos.X, pos.Y, radius);

    // Check intersection
    bool isIntersecting = CircleQuadIntersect(mouseCircle, fixedQuad);

    // Draw the quad using 2 triangles
    Color fillColor = isIntersecting ? Color.Red : Color.Green;
    FillTriangle(fillColor, p1.X, p1.Y, p2.X, p2.Y, p3.X, p3.Y);
    FillTriangle(fillColor, p1.X, p1.Y, p4.X, p4.Y, p3.X, p3.Y);

    // Draw circle
    DrawCircle(Color.White, mouseCircle);

    RefreshScreen(60);
}
