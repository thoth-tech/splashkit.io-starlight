// using static allows calling SplashKit methods directly (e.g. MoveMouse, KeyTyped)
// using SplashKitSDK is required for Point2D and KeyCode types
using static SplashKitSDK.SplashKit;
using SplashKitSDK;

// Define five target points using PointAt to create Point2D values
// These represent the four corners and the center of the window
Point2D topLeft     = PointAt(100, 100);
Point2D topRight    = PointAt(700, 100);
Point2D bottomLeft  = PointAt(100, 500);
Point2D bottomRight = PointAt(700, 500);
Point2D center      = PointAt(400, 300);

OpenWindow("Move Mouse To Point", 800, 600);

while (!QuitRequested())
{
    ProcessEvents();

    // MoveMouse (C#'s equivalent of move_mouse_to_point) repositions the cursor to the given Point2D location
    // Each key press snaps the mouse to the corresponding target point
    if (KeyTyped(KeyCode.QKey))
        MoveMouse(topLeft);
    if (KeyTyped(KeyCode.EKey))
        MoveMouse(topRight);
    if (KeyTyped(KeyCode.AKey))
        MoveMouse(bottomLeft);
    if (KeyTyped(KeyCode.DKey))
        MoveMouse(bottomRight);
    if (KeyTyped(KeyCode.SpaceKey))
        MoveMouse(center);

    ClearScreen(ColorWhite());

    // Draw a coloured circle at each target point so the user can see where the mouse will snap
    FillCircle(ColorRed(),    topLeft.X,     topLeft.Y,     12);
    FillCircle(ColorBlue(),   topRight.X,    topRight.Y,    12);
    FillCircle(ColorGreen(),  bottomLeft.X,  bottomLeft.Y,  12);
    FillCircle(ColorOrange(), bottomRight.X, bottomRight.Y, 12);
    FillCircle(ColorPurple(), center.X,      center.Y,      12);

    // Label each target with its corresponding key
    DrawText("[Q]",     ColorRed(),    "Arial", 16, topLeft.X - 12,     topLeft.Y + 18);
    DrawText("[E]",     ColorBlue(),   "Arial", 16, topRight.X - 12,    topRight.Y + 18);
    DrawText("[A]",     ColorGreen(),  "Arial", 16, bottomLeft.X - 12,  bottomLeft.Y + 18);
    DrawText("[D]",     ColorOrange(), "Arial", 16, bottomRight.X - 12, bottomRight.Y + 18);
    DrawText("[SPACE]", ColorPurple(), "Arial", 16, center.X - 28,      center.Y + 18);

    DrawText("Press Q/E/A/D/SPACE to move the mouse to a target point", ColorBlack(), "Arial", 18, 145, 260);

    RefreshScreen(60);
}

CloseAllWindows();
