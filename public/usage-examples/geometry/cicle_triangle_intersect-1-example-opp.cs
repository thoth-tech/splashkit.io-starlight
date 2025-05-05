using SplashKitSDK;

public class Program
{
    public static void Main()
    {
        // A fixed triangle is placed as the target.
        Window gameWindow = new Window("Circle-Triangle Intersect", 600, 600);
        Triangle target = SplashKit.TriangleFrom(300, 100, 250, 300, 350, 300);

        // A circle moves with arrow keys.
        Circle playerCircle = new Circle
        {
            Radius = 20,
            Center = SplashKit.PointAt(100, 100)
        };

        while (!gameWindow.CloseRequested)
        {
            SplashKit.ProcessEvents();

            if (SplashKit.KeyDown(KeyCode.UpKey)) playerCircle.Center.Y -= 0.5;
            if (SplashKit.KeyDown(KeyCode.DownKey)) playerCircle.Center.Y += 0.5;
            if (SplashKit.KeyDown(KeyCode.LeftKey)) playerCircle.Center.X -= 0.5;
            if (SplashKit.KeyDown(KeyCode.RightKey)) playerCircle.Center.X += 0.5;

            SplashKit.ClearScreen(Color.White);
            SplashKit.DrawTriangle(Color.Black, target);

            // The circle turns green and text is displayed if it touches the triangle.
            bool intersects = SplashKit.CircleTriangleIntersect(playerCircle, target);
            Color circleColor = intersects ? Color.Green : Color.Red;

            SplashKit.DrawCircle(circleColor, playerCircle.Center.X, playerCircle.Center.Y, playerCircle.Radius);

            // Demonstrates the circle_triangle_intersect function.
            if (intersects)
            {
                SplashKit.DrawText("Circle is Intersecting the triangle", Color.Black, 170, 20);
            }

            SplashKit.RefreshScreen(60);
        }
    }
}
'
