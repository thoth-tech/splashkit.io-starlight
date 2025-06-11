// This example demonstrates the use of SplashKit’s LineFrom(Point2D, Vector2D) function using OOP in C#
using SplashKitSDK;

public class VectorField
{
    private readonly double _spacingX;
    private readonly double _spacingY;
    private readonly Vector2D _direction;

    public VectorField()
    {
        _spacingX = 80;
        _spacingY = 60;
        _direction = SplashKit.VectorTo(20.0, 10.0); // Offset vector
    }

    public void Draw()
    {
        for (double x = 0; x < SplashKit.ScreenWidth(); x += _spacingX)
        {
            for (double y = 0; y < SplashKit.ScreenHeight(); y += _spacingY)
            {
                Point2D origin = new Point2D() { X = x, Y = y };
                Line segment = SplashKit.LineFrom(origin, _direction);
                SplashKit.DrawLine(Color.Green, segment);
            }
        }
    }
}

public class Program
{
    public static void Main()
    {
        // Open window
        SplashKit.OpenWindow("Vector Field with LineFrom", 800, 600);
        SplashKit.ClearScreen(Color.White);

        // Create and draw the vector field
        VectorField field = new VectorField();
        field.Draw();

        // Show results
        SplashKit.RefreshScreen();
        SplashKit.Delay(5000);  // Keep window open for 5 seconds
    }
}