using SplashKitSDK;
using static SplashKitSDK.SplashKit;

OpenWindow("Moving Triangle Intersection", 800, 600);

Triangle fixedTriangle = TriangleFrom(
    PointAt(250, 200),
    PointAt(400, 150),
    PointAt(350, 350)
);

while (!QuitRequested())
{
    ProcessEvents();

    Point2D mousePoint = MousePosition();

    Triangle movingTriangle = TriangleFrom(
        PointAt(mousePoint.X, mousePoint.Y - 60),
        PointAt(mousePoint.X - 60, mousePoint.Y + 40),
        PointAt(mousePoint.X + 60, mousePoint.Y + 40)
    );

    ClearScreen(ColorWhite());

    DrawTriangle(ColorBlue(), fixedTriangle);

    if (TrianglesIntersect(fixedTriangle, movingTriangle))
    {
        DrawTriangle(ColorRed(), movingTriangle);
        DrawText(
            "The triangles intersect",
            ColorRed(),
            250,
            50
        );
    }
    else
    {
        DrawTriangle(ColorGreen(), movingTriangle);
        DrawText(
            "The triangles do not intersect",
            ColorGreen(),
            225,
            50
        );
    }

    RefreshScreen(60);
}

CloseAllWindows();
