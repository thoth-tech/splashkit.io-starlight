using SplashKitSDK;
using static SplashKitSDK.SplashKit;

OpenWindow("Mouse Position Arrow", 800, 600);

while (!QuitRequested())
{
    ProcessEvents();

    // The vector runs from the window origin (the top-left corner) to the mouse
    SplashKitSDK.Vector2D mouseVector = MousePositionVector();

    ClearScreen(ColorWhite());

    DrawLine(ColorBlue(), 0, 0, mouseVector.X, mouseVector.Y);

    // Two short lines swept back from the tip make the arrowhead
    double arrowAngle = VectorAngle(mouseVector);
    SplashKitSDK.Vector2D headLeft = VectorFromAngle(arrowAngle + 150, 25);
    SplashKitSDK.Vector2D headRight = VectorFromAngle(arrowAngle - 150, 25);
    DrawLine(ColorBlue(), mouseVector.X, mouseVector.Y, mouseVector.X + headLeft.X, mouseVector.Y + headLeft.Y);
    DrawLine(ColorBlue(), mouseVector.X, mouseVector.Y, mouseVector.X + headRight.X, mouseVector.Y + headRight.Y);

    DrawText("Move the mouse to aim the arrow from the corner.", ColorBlack(), 20, 510);
    DrawText("Vector X: " + (int)mouseVector.X, ColorBlack(), 20, 540);
    DrawText("Vector Y: " + (int)mouseVector.Y, ColorBlack(), 20, 570);

    RefreshScreen(60);
}

CloseAllWindows();
