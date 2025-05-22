using SplashKitSDK;
using static SplashKitSDK.SplashKit;

OpenWindow("Circular Toggle Button", 800, 600);

//Declaring the variables
Color circleColor;
Color textColor;
Color bgColor = ColorWhite();
string text;
Point2D cursorPos;
Circle circle = CircleAt(400, 300, 80);

while (!QuitRequested())
{
    ProcessEvents();

    cursorPos = MousePosition();

    // Check for mouse position in relation to circle
    if (PointInCircle(cursorPos, circle))
    {
        circleColor = ColorGreen();
        textColor = ColorGreen();
        text = "Point is in the circle";
        circle.Radius = 90;
        if (MouseClicked(MouseButton.LeftButton))
        {
            bgColor = RandomColor();
        }
    }
    else
    {
        circleColor = ColorBrightGreen();
        textColor = ColorRed();
        text = "Point is not in the circle";
        circle.Radius = 80;
    }

    // Display the button and results
    ClearScreen(bgColor);
    DrawText("Click the button to change colour of the Screen", ColorBlack(), 200, 100);
    DrawText(text, textColor, 300, 150);
    FillCircle(circleColor, circle);
    DrawText("Button", ColorBlack(), 375, 300);
    RefreshScreen();
}
CloseAllWindows();
