using SplashKitSDK;
using static SplashKitSDK.SplashKit;

OpenWindow("Widest points on a circle along a vector", 600, 600);

// Declare variables
Point2D circleCenter = ScreenCenter();
Circle circle = CircleAt(circleCenter, 100);
Point2D mousePos;
Vector2D directionVector;
Point2D widestPoint1 = new Point2D();
Point2D widestPoint2 = new Point2D();

while (!QuitRequested())
{
    ProcessEvents();

    // Get current mouse position
    mousePos = MousePosition();

    // Calculate the direction vector from the circle center to the mouse position
    directionVector = VectorPointToPoint(circle.Center, mousePos);

    // Calculate the widest points along the direction vector (using ref)
    WidestPoints(circle, directionVector, ref widestPoint1, ref widestPoint2);

    // Draw everything
    ClearScreen();
    DrawCircle(ColorBlack(), circle);
    FillCircle(ColorRed(), widestPoint1.X, widestPoint1.Y, 5);
    FillCircle(ColorRed(), widestPoint2.X, widestPoint2.Y, 5);
    FillCircle(ColorBlue(), mousePos.X, mousePos.Y, 5);
    DrawLine(ColorGreen(), circle.Center, mousePos);
    DrawLine(ColorRed(), circle.Center, widestPoint1);
    DrawLine(ColorRed(), circle.Center, widestPoint2);

    // Show calculation details
    DrawText($"Mouse Position (Vector Direction): ({(int)mousePos.X}, {(int)mousePos.Y})",
        ColorBlack(), "Arial", 16, 10, 10);

    DrawText($"Widest Point 1: ({(int)widestPoint1.X}, {(int)widestPoint1.Y})",
        ColorBlack(), "Arial", 16, 10, 35);

    DrawText($"Widest Point 2: ({(int)widestPoint2.X}, {(int)widestPoint2.Y})",
        ColorBlack(), "Arial", 16, 10, 60);

    RefreshScreen();
}

CloseAllWindows();
