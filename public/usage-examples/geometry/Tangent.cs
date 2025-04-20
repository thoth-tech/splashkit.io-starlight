using SplashKitSDK;

public class WidestTangentApp
{
    private Circle _circle;
    private Point2D _mouse;
    private Point2D _p1, _p2;

    public WidestTangentApp()
    {
        _circle.Center = new Point2D() { X = 400, Y = 300 };
        _circle.Radius = 100;
    }

    public bool TangentPoints(Point2D fromPt, out Point2D p1, out Point2D p2)
    {
        Vector2D v = SplashKit.VectorPointToPoint(_circle.Center, fromPt);
        float d = SplashKit.VectorMagnitude(v);
        p1 = new Point2D(); p2 = new Point2D();
        if (d < _circle.Radius) return false;

        float angle = (float)Math.Atan2(v.Y, v.X);
        float offset = (float)Math.Acos(_circle.Radius / d);

        float a1 = angle + offset;
        float a2 = angle - offset;

        p1.X = _circle.Center.X + _circle.Radius * (float)Math.Cos(a1);
        p1.Y = _circle.Center.Y + _circle.Radius * (float)Math.Sin(a1);
        p2.X = _circle.Center.X + _circle.Radius * (float)Math.Cos(a2);
        p2.Y = _circle.Center.Y + _circle.Radius * (float)Math.Sin(a2);
        return true;
    }

    public void Run()
    {
        SplashKit.OpenWindow("C# Tangent OOP", 800, 600);
        while (!SplashKit.WindowCloseRequested("C# Tangent OOP"))
        {
            SplashKit.ProcessEvents();
            _mouse = new Point2D() { X = SplashKit.MouseX(), Y = SplashKit.MouseY() };
            bool valid = TangentPoints(_mouse, out _p1, out _p2);

            SplashKit.ClearScreen(Color.White);
            SplashKit.DrawCircle(Color.Black, _circle);
            SplashKit.FillCircle(Color.Red, _mouse.X, _mouse.Y, 5);

            if (valid)
            {
                SplashKit.FillCircle(Color.Blue, _p1.X, _p1.Y, 5);
                SplashKit.FillCircle(Color.Blue, _p2.X, _p2.Y, 5);
                SplashKit.DrawLine(Color.Green, _mouse, _p1);
                SplashKit.DrawLine(Color.Green, _mouse, _p2);
            }

            SplashKit.DrawText($"External Point: ({(int)_mouse.X}, {(int)_mouse.Y})", Color.Black, 10, 10);
            SplashKit.RefreshScreen(60);
        }
    }
}
