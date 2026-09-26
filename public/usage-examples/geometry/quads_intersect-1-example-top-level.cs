using SplashKitSDK;
using static SplashKitSDK.SplashKit;

OpenWindow("Quads Intersect", 800, 600);

Quad fixedQuad = QuadFrom(
    500, 200,
    470, 380,
    300, 180,
    280, 350
);

while (!QuitRequested())
{
    ProcessEvents();

    Point2D mouse = MousePosition();

    Quad movingQuad = QuadFrom(
        mouse.X + 60, mouse.Y - 45,
        mouse.X + 60, mouse.Y + 45,
        mouse.X - 60, mouse.Y - 45,
        mouse.X - 60, mouse.Y + 45
    );

    bool intersects = QuadsIntersect(fixedQuad, movingQuad);

    ClearScreen(ColorWhite());

    FillQuad(ColorLightGray(), fixedQuad);
    DrawQuad(ColorBlack(), fixedQuad);

    if (intersects)
    {
        FillQuad(ColorRed(), movingQuad);
        DrawText(
            "Quads intersect: TRUE",
            ColorDarkRed(),
            20,
            20
        );
    }
    else
    {
        FillQuad(ColorBlue(), movingQuad);
        DrawText(
            "Quads intersect: FALSE",
            ColorBlack(),
            20,
            20
        );
    }

    DrawQuad(ColorBlack(), movingQuad);

    DrawText(
        "Move the mouse to test quad intersection",
        ColorBlack(),
        20,
        550
    );

    RefreshScreen(60);
}

CloseAllWindows();
