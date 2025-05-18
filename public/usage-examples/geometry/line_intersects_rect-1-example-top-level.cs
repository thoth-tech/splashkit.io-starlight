using static SplashKitSDK.SplashKit;

// Create and open a new window
Window window = OpenWindow("Line Intersects Rect", 800, 600);

// Define a draggable line
Point2D startPt = PointAt(100, 100);
Point2D endPt = PointAt(700, 500);
Line line = LineFrom(startPt, endPt);

// Define a static rectangle
Rectangle rect = RectangleFrom(300, 200, 200, 150);

while (!window.CloseRequested)
{
    ProcessEvents();

    // Move the line ends with mouse
    if (MouseDown(MouseButton.LeftButton))
    {
        if (PointInCircle(MousePosition(), CircleAt(startPt, 10)))
        {
            startPt = MousePosition();
        }
        else if (PointInCircle(MousePosition(), CircleAt(endPt, 10)))
        {
            endPt = MousePosition();
        }
    }

    // Update the line
    line = LineFrom(startPt, endPt);

    // Check for intersection
    bool intersects = LineIntersectsRect(line, rect);

    ClearScreen(ColorWhite());

    // Draw the rectangle
    DrawRectangle(ColorBlue(), rect);

    // Draw the line
    DrawLine(ColorBlack(), line);

    // Draw draggable points
    DrawCircle(ColorGreen(), startPt.X, startPt.Y, 5);
    DrawCircle(ColorGreen(), endPt.X, endPt.Y, 5);

    // Show text when intersecting
    if (intersects)
    {
        DrawText("Intersecting", ColorRed(), "Arial", 20, 10, 10);
    }

    RefreshScreen();
}
