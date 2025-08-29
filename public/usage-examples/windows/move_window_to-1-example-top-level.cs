using static SplashKitSDK.SplashKit;

OpenWindow("Move Window Example", 300, 300);
while (!QuitRequested())
{
    // Get user inputs
    ProcessEvents();

    ClearScreen(ColorWhite());

    // Get position of the window
    int currentX = WindowX("Move Window Example");
    int currentY = WindowY("Move Window Example");

    // Move window buttons
    if (Button("NW", RectangleFrom(50, 50, 40, 40)))
    {
        MoveWindowTo("Move Window Example", currentX - 10, currentY - 10);
    }

    if (Button("N", RectangleFrom(130, 50, 40, 40)))
    {
        MoveWindowTo("Move Window Example", currentX, currentY - 10);
    }

    if (Button("NE", RectangleFrom(210, 50, 40, 40)))
    {
        MoveWindowTo("Move Window Example", currentX + 10, currentY - 10);
    }

    if (Button("W", RectangleFrom(50, 130, 40, 40)))
    {
        MoveWindowTo("Move Window Example", currentX - 10, currentY);
    }

    if (Button("E", RectangleFrom(210, 130, 40, 40)))
    {
        MoveWindowTo("Move Window Example", currentX + 10, currentY);
    }

    if (Button("SW", RectangleFrom(50, 210, 40, 40)))
    {
        MoveWindowTo("Move Window Example", currentX - 10, currentY + 10);
    }

    if (Button("S", RectangleFrom(130, 210, 40, 40)))
    {
        MoveWindowTo("Move Window Example", currentX, currentY + 10);
    }

    if (Button("SE", RectangleFrom(210, 210, 40, 40)))
    {
        MoveWindowTo("Move Window Example", currentX + 10, currentY + 10);
    }

    DrawInterface();
    RefreshScreen();
}

// close all open windows
CloseAllWindows();