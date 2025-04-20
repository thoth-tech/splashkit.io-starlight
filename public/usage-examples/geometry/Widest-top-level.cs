using SplashKitSDK;

SplashKit.OpenWindow("Widest Points C# Top Level", 800, 600);

Circle circle;
circle.Center = new Point2D() { X = 400, Y = 300 };
circle.Radius = 100;

Vector2D direction = SplashKit.UnitVector(SplashKit.VectorPointToPoint(
    new Point2D() { X = 0, Y = 0 },
    new Point2D() { X = 1, Y = 2 }
));

Vector2D offset = SplashKit.VectorMultiply(direction, circle.Radius);

Point2D pt1 = new Point2D()
{
    X = circle.Center.X + offset.X,
    Y = circle.Center.Y + offset.Y
};

Point2D pt2 = new Point2D()
{
    X = circle.Center.X - offset.X,
    Y = circle.Center.Y - offset.Y
};

while (!SplashKit.WindowCloseRequested("Widest Points C# Top Level"))
{
    SplashKit.ProcessEvents();
    SplashKit.ClearScreen(Color.White);

    SplashKit.DrawCircle(Color.SkyBlue, circle);
    SplashKit.DrawLine(Color.DarkGray, circle.Center,
        new Point2D()
        {
            X = circle.Center.X + direction.X * circle.Radius,
            Y = circle.Center.Y + direction.Y * circle.Radius
        });

    SplashKit.FillCircle(Color.Red, pt1.X, pt1.Y, 5);
    SplashKit.FillCircle(Color.Red, pt2.X, pt2.Y, 5);

    SplashKit.DrawText($"Vector: ({direction.X:0.00}, {direction.Y:0.00})", Color.Black, 10, 30);
    SplashKit.DrawText($"Point 1: ({pt1.X:0.00}, {pt1.Y:0.00})", Color.Black, 10, 50);
    SplashKit.DrawText($"Point 2: ({pt2.X:0.00}, {pt2.Y:0.00})", Color.Black, 10, 70);

    SplashKit.RefreshScreen(60);
}
