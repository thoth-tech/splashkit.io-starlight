using SplashKitSDK;
using static SplashKitSDK.SplashKit;

OpenWindow("Point In Quad", 800, 600);

Color quadColor;
string text;
Quad quad = QuadFrom(PointAt(250, 180), PointAt(500, 210), PointAt(300, 380), PointAt(480, 480));
            
while (!QuitRequested())
{
    ProcessEvents();
    Point2D cursorPos = MousePosition();

    // The text and quad colour is updated depending on whether cursor is inside the quad
    if (PointInQuad(cursorPos, quad))
    {
        quadColor = ColorGreen();
        text = "Cursor in the quad!";
    }
    else
    {
        quadColor = ColorRed();
        text = "Cursor not in the quad!";
    }

    ClearScreen(ColorWhite());
    DrawQuad(quadColor, quad);
    DrawText(text, quadColor, 300, 100);
    RefreshScreen();
}
CloseAllWindows();