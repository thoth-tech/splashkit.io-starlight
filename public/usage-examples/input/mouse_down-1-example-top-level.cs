using SplashKitSDK;
using static SplashKitSDK.SplashKit;

OpenWindow("Mouse Drag Example", 800, 600);

double circleX = 400;
double circleY = 300;
const double circleRadius = 50;

bool dragging = false;
bool wasMouseDown = false;

double offsetX = 0;
double offsetY = 0;

while (!QuitRequested())
{
    ProcessEvents();

    Point2D mouse = MousePosition();
    bool leftMouseDown = MouseDown(MouseButton.LeftButton);

    // Start dragging when the circle is pressed
    if (
        !dragging &&
        leftMouseDown &&
        !wasMouseDown &&
        PointInCircle(mouse, CircleAt(circleX, circleY, circleRadius))
    )
    {
        dragging = true;

        offsetX = circleX - mouse.X;
        offsetY = circleY - mouse.Y;
    }

    // Move the circle while dragging
    if (dragging && leftMouseDown)
    {
        circleX = mouse.X + offsetX;
        circleY = mouse.Y + offsetY;
    }

    // Stop dragging when released
    if (!leftMouseDown)
    {
        dragging = false;
    }

    wasMouseDown = leftMouseDown;

    ClearScreen(ColorWhite());

    if (dragging)
    {
        FillCircle(ColorRed(), circleX, circleY, circleRadius);
    }
    else
    {
        FillCircle(ColorBlue(), circleX, circleY, circleRadius);
    }

    DrawText("Click and drag the circle", ColorBlack(), 20, 20);

    RefreshScreen(60);
}

CloseAllWindows();