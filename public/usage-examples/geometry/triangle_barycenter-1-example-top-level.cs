using SplashKitSDK;
using static SplashKitSDK.SplashKit;

OpenWindow("Triangle Barycenter", 800, 600);

Triangle tri = TriangleFrom(
    200, 450,
    400, 120,
    620, 450
);

Point2D barycenter = TriangleBarycenter(tri);

while (!QuitRequested())
{
    ProcessEvents();

    ClearScreen(Color.White);

    FillTriangle(Color.LightBlue, tri);
    DrawTriangle(Color.Black, tri);

    FillCircle(Color.Red, barycenter.X, barycenter.Y, 8);

    DrawText(
        "Triangle Barycenter",
        Color.Black,
        20,
        20
    );

    DrawText(
        "The red point shows the barycenter of the triangle.",
        Color.Black,
        20,
        50
    );

    RefreshScreen(60);
}

CloseAllWindows();