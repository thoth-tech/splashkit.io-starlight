using SplashKitSDK;
using static SplashKitSDK.SplashKit;

OpenWindow("Triangle Rectangle Intersect Example", 800, 600);

double rectX = 300;
double rectY = 220;
double rectWidth = 200;
double rectHeight = 160;

Rectangle targetRect = RectangleFrom(
    rectX,
    rectY,
    rectWidth,
    rectHeight
);

while (!QuitRequested())
{
    ProcessEvents();

    double mouseXPos = MouseX();
    double mouseYPos = MouseY();

    double x1 = mouseXPos;
    double y1 = mouseYPos - 60;

    double x2 = mouseXPos - 60;
    double y2 = mouseYPos + 50;

    double x3 = mouseXPos + 60;
    double y3 = mouseYPos + 50;

    Triangle movingTriangle = TriangleFrom(
        PointAt(x1, y1),
        PointAt(x2, y2),
        PointAt(x3, y3)
    );

    bool intersects = TriangleRectangleIntersect(
        movingTriangle,
        targetRect
    );

    ClearScreen(ColorWhite());

    FillRectangle(
        ColorGray(),
        rectX,
        rectY,
        rectWidth,
        rectHeight
    );

    DrawRectangle(
        ColorBlack(),
        rectX,
        rectY,
        rectWidth,
        rectHeight
    );

    if (intersects)
    {
        FillTriangle(
            ColorRed(),
            x1,
            y1,
            x2,
            y2,
            x3,
            y3
        );
    }
    else
    {
        FillTriangle(
            ColorBlue(),
            x1,
            y1,
            x2,
            y2,
            x3,
            y3
        );
    }

    DrawTriangle(
        ColorBlack(),
        x1,
        y1,
        x2,
        y2,
        x3,
        y3
    );

    DrawText(
        "Move the triangle with your mouse",
        ColorBlack(),
        230,
        40
    );

    if (intersects)
    {
        DrawText(
            "Intersection detected!",
            ColorRed(),
            300,
            520
        );
    }
    else
    {
        DrawText(
            "No intersection",
            ColorBlack(),
            330,
            520
        );
    }

    RefreshScreen(60);
}

CloseAllWindows();
