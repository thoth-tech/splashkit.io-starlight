using SplashKitSDK;
using static SplashKitSDK.SplashKit;

OpenWindow("Triangle Quad Intersect", 800, 600);

// Create a fixed quad
Quad targetQuad = QuadFrom(
    450, 180,
    650, 180,
    450, 380,
    650, 380
);

while (!QuitRequested())
{
    ProcessEvents();

    // Get current mouse position
    Point2D mousePoint = MousePosition();
    double mx = mousePoint.X;
    double my = mousePoint.Y;

    // Create a triangle that follows the mouse
    Triangle movingTriangle = TriangleFrom(
        mx, my - 60,
        mx - 60, my + 50,
        mx + 60, my + 50
    );

    // Check whether the triangle intersects the quad
    bool intersects = TriangleQuadIntersect(
        movingTriangle,
        targetQuad
    );

    ClearScreen(ColorWhite());

    FillQuad(ColorLightGray(), targetQuad);
    DrawQuad(ColorBlack(), targetQuad);

    if (intersects)
    {
        FillTriangle(ColorRed(), movingTriangle);
        DrawText(
            "Triangle intersects the quad!",
            ColorRed(),
            20,
            20
        );
    }
    else
    {
        FillTriangle(ColorBlue(), movingTriangle);
        DrawText(
            "Move the triangle into the quad",
            ColorBlack(),
            20,
            20
        );
    }

    DrawTriangle(ColorBlack(), movingTriangle);

    RefreshScreen(60);
}

CloseAllWindows();
