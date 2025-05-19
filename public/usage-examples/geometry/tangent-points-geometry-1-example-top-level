using SplashKitSDK;
using static SplashKitSDK.SplashKit;

OpenWindow("Tangent Points Calculation", 800, 600);
Circle circle = CircleAt(PointAt(400, 300), 100);

while (!QuitRequested())
{
    ProcessEvents();
    Point2D cursorPos = MousePosition();

    ClearScreen(ColorWhite());

    // Draw the circle
    DrawCircle(ColorBlack(), circle);

    // Draw the external point (mouse)
    FillCircle(ColorBlue(), cursorPos.X, cursorPos.Y, 5);

    // Display mouse coordinates
    DrawText($"Mouse Position (External Point): ({(int)cursorPos.X}, {(int)cursorPos.Y})",
        ColorBlack(), "Arial", 16, 10, 10);

    // Calculate and draw tangent points if mouse is outside the circle
    if (TangentPoints(cursorPos, circle, out var tangent1, out var tangent2))
    {
        FillCircle(ColorRed(), tangent1.X, tangent1.Y, 5);
        FillCircle(ColorRed(), tangent2.X, tangent2.Y, 5);
        DrawLine(ColorGreen(), cursorPos, tangent1);
        DrawLine(ColorGreen(), cursorPos, tangent2);

        // Show tangent point coordinates
        DrawText($"Tangent 1: ({(int)tangent1.X}, {(int)tangent1.Y})",
            ColorBlack(), "Arial", 16, 10, 35);
        DrawText($"Tangent 2: ({(int)tangent2.X}, {(int)tangent2.Y})",
            ColorBlack(), "Arial", 16, 10, 60);
    }
    else
    {
        DrawText("Move the mouse outside the circle to see tangent points.",
            ColorBlack(), "Arial", 16, 10, 35);
    }

    RefreshScreen();
}

CloseAllWindows();
