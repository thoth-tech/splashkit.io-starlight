// This example demonstrates the use of SplashKit’s LineFrom(Point2D, Vector2D) function using top-level OOP style
using SplashKitSDK;

// Top-level entry point
SplashKit.OpenWindow("Vector Field with LineFrom", 800, 600);
SplashKit.ClearScreen(Color.White);

new VectorField().Draw();

SplashKit.RefreshScreen();
SplashKit.Delay(5000);

// OOP class definition placed after top-level statements
class VectorField
{
    private readonly Vector2D _direction = SplashKit.VectorTo(20.0, 10.0);

    public void Draw(double spacingX = 80, double spacingY = 60)
    {
        for (double x = 0; x < SplashKit.ScreenWidth(); x += spacingX)
        {
            for (double y = 0; y < SplashKit.ScreenHeight(); y += spacingY)
            {
                Point2D start = new Point2D { X = x, Y = y };
                Line segment = SplashKit.LineFrom(start, _direction);
                SplashKit.DrawLine(Color.Green, segment);
            }
        }
    }
}