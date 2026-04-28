using SplashKitSDK;
using static SplashKitSDK.SplashKit;

OpenWindow("Dot Product of Vectors", 800, 600);

// Use one shared starting point for both vectors
Point2D origin = PointAt(400, 300);

// Create two vectors with different directions
Vector2D firstVector = VectorTo(150, -100);
Vector2D secondVector = VectorTo(200, 80);

while (!QuitRequested())
{
    ProcessEvents();

    // Calculate the dot product of the two vectors
    double result = DotProduct(firstVector, secondVector);

    ClearScreen(ColorWhite());

    // Draw both vectors from the same origin point
    DrawLine(ColorBlue(), origin.X, origin.Y, origin.X + firstVector.X, origin.Y + firstVector.Y);
    DrawLine(ColorRed(), origin.X, origin.Y, origin.X + secondVector.X, origin.Y + secondVector.Y);

    // Label the vectors and show the dot product value
    DrawText("Blue vector", ColorBlue(), 520, 180);
    DrawText("Red vector", ColorRed(), 560, 390);
    DrawText("Dot product: " + result.ToString("0.00"), ColorBlack(), 260, 40);

    RefreshScreen(60);
}

CloseAllWindows();