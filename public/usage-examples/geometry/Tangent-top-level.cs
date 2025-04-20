using SplashKitSDK;

SplashKit.OpenWindow("C# Tangents Top Level", 800, 600);
Circle c = new Circle();
c.Center = new Point2D() { X = 400, Y = 300 };
c.Radius = 100;

while (!SplashKit.WindowCloseRequested("C# Tangents Top Level"))
{
    SplashKit.ProcessEvents();
    Point2D m = new Point2D() { X = SplashKit.MouseX(), Y = SplashKit.MouseY() };
    Vector2D v = SplashKit.VectorPointToPoint(c.Center, m);
    float d = SplashKit.VectorMagnitude(v);

    SplashKit.ClearScreen(Color.White);
    SplashKit.DrawCircle(Color.Black, c);
    SplashKit.FillCircle(Color.Red, m.X, m.Y, 5);

    if (d >= c.Radius)
    {
        float angle = (float)Math.Atan2(v.Y, v.X);
        float offset = (float)Math.Acos(c.Radius / d);

        float a1 = angle + offset;
        float a2 = angle - offset;

        Point2D p1 = new Point2D() { X = c.Center.X + c.Radius * (float)Math.Cos(a1), Y = c.Center.Y + c.Radius * (float)Math.Sin(a1) };
        Point2D p2 = new Point2D() { X = c.Center.X + c.Radius * (float)Math.Cos(a2), Y = c.Center.Y + c.Radius * (float)Math.Sin(a2) };

        SplashKit.FillCircle(Color.Blue, p1.X, p1.Y, 5);
        SplashKit.FillCircle(Color.Blue, p2.X, p2.Y, 5);
        SplashKit.DrawLine(Color.Green, m, p1);
        SplashKit.DrawLine(Color.Green, m, p2);
    }

    SplashKit.DrawText($"External Point: ({(int)m.X}, {(int)m.Y})", Color.Black, 10, 10);
    SplashKit.RefreshScreen(60);
}
