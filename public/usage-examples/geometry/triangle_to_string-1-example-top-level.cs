using SplashKitSDK;
using static SplashKitSDK.SplashKit;

OpenWindow("Triangle To String", 800, 600);

// Create a triangle to describe
Triangle demoTriangle = new Triangle()
{
    Points = new Point2D[]
    {
        PointAt(300, 200),
        PointAt(500, 200),
        PointAt(400, 400)
    }
};

while (!QuitRequested())
{
    ProcessEvents();

    // Convert the triangle into a text description
    string triangleText = TriangleToString(demoTriangle);

    ClearScreen(ColorWhite());

    // Draw the triangle
    DrawTriangle(ColorBlue(), demoTriangle);

    // Display the generated text
    DrawText("Triangle description:", ColorBlack(), 20, 20);
    DrawText(triangleText, ColorBlack(), 20, 50);

    RefreshScreen(60);
}