using SplashKitSDK;
using static SplashKitSDK.SplashKit;

OpenWindow("Triangle Ray Intersection", 800, 600);

Point2D rayOrigin = PointAt(120, 300);

Triangle tri = TriangleFrom(
    PointAt(500, 180),
    PointAt(650, 420),
    PointAt(420, 420)
);

while (!QuitRequested())
{
    ProcessEvents();

    Point2D mouse = MousePosition();

    Vector2D heading = VectorTo(
        mouse.X - rayOrigin.X,
        mouse.Y - rayOrigin.Y
    );

    bool intersects = TriangleRayIntersection(
        rayOrigin,
        heading,
        tri
    );

    ClearScreen(Color.White);

    if (intersects)
    {
        FillTriangle(Color.Green, tri);

        DrawText(
            "Ray intersects the triangle",
            Color.Green,
            20,
            20
        );
    }
    else
    {
        FillTriangle(Color.Red, tri);

        DrawText(
            "Ray does not intersect the triangle",
            Color.Red,
            20,
            20
        );
    }

    DrawTriangle(Color.Black, tri);

    DrawCircle(
        Color.Blue,
        rayOrigin.X,
        rayOrigin.Y,
        6
    );

    double rayLength = 1000;

    Point2D rayEnd = PointAt(
        rayOrigin.X + heading.X * rayLength,
        rayOrigin.Y + heading.Y * rayLength
    );

    DrawLine(
        Color.Blue,
        rayOrigin.X,
        rayOrigin.Y,
        rayEnd.X,
        rayEnd.Y
    );

    DrawText(
        "Move the mouse to change the ray direction",
        Color.Black,
        20,
        550
    );

    RefreshScreen(60);
}

CloseAllWindows();
