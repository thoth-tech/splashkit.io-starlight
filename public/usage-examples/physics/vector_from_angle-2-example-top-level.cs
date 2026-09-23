using SplashKitSDK;
using static SplashKitSDK.SplashKit;

OpenWindow("Vector From Angle", 800, 600);

double angle = 0;
const double length = 180;

while (!QuitRequested())
{
    ProcessEvents();

    if (KeyDown(KeyCode.LeftKey))
    {
        angle -= 2;
    }

    if (KeyDown(KeyCode.RightKey))
    {
        angle += 2;
    }

    Point2D center = PointAt(
        ScreenWidth() / 2,
        ScreenHeight() / 2
    );

    Vector2D direction = VectorFromAngle(angle, length);

    Point2D end = PointAt(
        center.X + direction.X,
        center.Y + direction.Y
    );

    ClearScreen(ColorBlack());

    DrawLine(
        ColorDeepSkyBlue(),
        center.X,
        center.Y,
        end.X,
        end.Y
    );

    FillCircle(
        ColorYellow(),
        end.X,
        end.Y,
        10
    );

    FillCircle(
        ColorWhite(),
        center.X,
        center.Y,
        6
    );

    DrawText(
        $"Angle: {angle:0} degrees",
        ColorWhite(),
        20,
        20
    );

    DrawText(
        "Use Left/Right Arrow Keys",
        ColorLightGray(),
        20,
        50
    );

    RefreshScreen(60);
}

CloseAllWindows();