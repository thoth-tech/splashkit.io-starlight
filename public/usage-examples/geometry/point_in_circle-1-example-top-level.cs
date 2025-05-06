using SplashKitSDK;
using static SplashKitSDK.SplashKit;

OpenWindow("Circular Toggle Button", 800, 600);

while (!QuitRequested())
{
    ProcessEvents();

    //Declaring the variables
    Color circleColor;
    Point2D cursorPos = MousePosition();
    Circle circle = CircleAt(400, 300, 80);

    ClearScreen();

    if (PointInCircle(cursorPos, circle))
    {
        circleColor = ColorGreen();
        DrawText("Point is in the circle", ColorGreen(), 300, 100);
    }
    else
    {
        circleColor = ColorBrightGreen();
        DrawText("Point is not in the circle", ColorRed(), 300, 100);
    }

    FillCircle(circleColor, circle);
    DrawText("Button", Color.Black, 375, 300);

    RefreshScreen();
}
CloseAllWindows();
