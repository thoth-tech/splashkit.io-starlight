using SplashKitSDK;
using static SplashKitSDK.SplashKit;

OpenWindow("Circle Click Display", 800, 600);

string clickedCircle = "None";
int clickCount = 0;

while (!QuitRequested())
{
    ProcessEvents();

    if (MouseClicked(MouseButton.LeftButton))
    {
        Point2D mousePoint = MousePosition();

        if (PointInCircle(mousePoint, CircleAt(180, 250, 60)))
        {
            clickedCircle = "Red";
            clickCount++;
        }
        else if (PointInCircle(mousePoint, CircleAt(400, 250, 60)))
        {
            clickedCircle = "Blue";
            clickCount++;
        }
        else if (PointInCircle(mousePoint, CircleAt(620, 250, 60)))
        {
            clickedCircle = "Green";
            clickCount++;
        }
    }

    ClearScreen(ColorWhite());

    DrawText("Click a circle to see which one was selected.", ColorBlack(), 20, 20);
    DrawText("Last clicked: " + clickedCircle, ColorBlack(), 20, 60);
    DrawText("Total clicks: " + clickCount, ColorBlack(), 20, 100);

    FillCircle(ColorRed(), 180, 250, 60);
    DrawCircle(ColorBlack(), 180, 250, 60);

    FillCircle(ColorBlue(), 400, 250, 60);
    DrawCircle(ColorBlack(), 400, 250, 60);

    FillCircle(ColorGreen(), 620, 250, 60);
    DrawCircle(ColorBlack(), 620, 250, 60);

    DrawText("Red", ColorBlack(), 155, 330);
    DrawText("Blue", ColorBlack(), 375, 330);
    DrawText("Green", ColorBlack(), 590, 330);

    RefreshScreen(60);
}

CloseAllWindows();