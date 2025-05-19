using SplashKitSDK;

public class WidestPointApp
{
    private Circle _circle;
    private Vector2D _direction;
    private Point2D _pt1, _pt2;

    public WidestPointApp()
    {
        _circle.Center = new Point2D() { X = 400, Y = 300 };
        _circle.Radius = 100;

        _direction = SplashKit.UnitVector(SplashKit.VectorPointToPoint(new Point2D() { X = 0, Y = 0 }, new Point2D() { X = 1, Y = 2 }));

        CalculateWidestPoints();
    }

    private void CalculateWidestPoints()
    {
        Vector2D offset = SplashKit.VectorMultiply(_direction, _circle.Radius);

        _pt1.X = _circle.Center.X + offset.X;
        _pt1.Y = _circle.Center.Y + offset.Y;

        _pt2.X = _circle.Center.X - offset.X;
        _pt2.Y = _circle.Center.Y - offset.Y;
    }

    public void Run()
    {
        SplashKit.OpenWindow("Widest Points C# OOP", 800, 600);

        while (!SplashKit.WindowCloseRequested("Widest Points C# OOP"))
        {
            SplashKit.ProcessEvents();
            SplashKit.ClearScreen(Color.White);

            SplashKit.DrawCircle(Color.SkyBlue, _circle);
            SplashKit.DrawLine(Color.DarkGray, _circle.Center, new Point2D()
            {
                X = _circle.Center.X + _direction.X * _circle.Radius,
                Y = _circle.Center.Y + _direction.Y * _circle.Radius
            });

            SplashKit.FillCircle(Color.Red, _pt1.X, _pt1.Y, 5);
            SplashKit.FillCircle(Color.Red, _pt2.X, _pt2.Y, 5);

            SplashKit.DrawText($"Vector: ({_direction.X:0.00}, {_direction.Y:0.00})", Color.Black, 10, 30);
            SplashKit.DrawText($"Point 1: ({_pt1.X:0.00}, {_pt1.Y:0.00})", Color.Black, 10, 50);
            SplashKit.DrawText($"Point 2: ({_pt2.X:0.00}, {_pt2.Y:0.00})", Color.Black, 10, 70);

            SplashKit.RefreshScreen(60);
        }
    }
}
