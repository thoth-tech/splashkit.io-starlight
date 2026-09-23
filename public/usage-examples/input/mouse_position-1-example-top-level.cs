using SplashKitSDK;
using static SplashKitSDK.SplashKit;

OpenWindow("Mouse Position Display", 800, 600);

while (!QuitRequested())
{
    ProcessEvents();

    Point2D mousePoint = MousePosition();

    ClearScreen(ColorWhite());

    DrawText("Move the mouse to track its position in the window.", ColorBlack(), 20, 20);
    DrawText("Mouse X: " + mousePoint.X, ColorBlack(), 20, 60);
    DrawText("Mouse Y: " + mousePoint.Y, ColorBlack(), 20, 100);

    FillCircle(ColorBlue(), mousePoint.X, mousePoint.Y, 8);
    DrawCircle(ColorBlack(), mousePoint.X, mousePoint.Y, 8);

    RefreshScreen(60);
}

CloseAllWindows();