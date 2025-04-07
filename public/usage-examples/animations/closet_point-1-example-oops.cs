using SplashKitSDK;

public class CircleClosetPoint
{
    private Circle _circle;
    private Line _line;

    public CircleClosetPoint()
    {
        _circle = new Circle(400, 300, 50); // Create a circle at a specific location with radius 50
        _line = new Line(200, 100, 600, 500); // Define a line with two points
    }

    public void Run()
    {
        SplashKit.OpenWindow("Closest Point on Line", 800, 600);

        while (!SplashKit.WindowCloseRequested("Closest Point on Line"))
        {
            SplashKit.ProcessEvents();

            // Update circle's center position with the mouse position
            _circle.Center = SplashKit.MousePosition();

            // Find closest point on line
            Point2D closestPoint = GetClosestPointOnLine(_circle, _line);

            SplashKit.ClearScreen(Color.White);

            // Draw the line and circle
            SplashKit.DrawLine(Color.Red, _line.StartPoint.X, _line.StartPoint.Y, _line.EndPoint.X, _line.EndPoint.Y);
            SplashKit.DrawCircle(Color.Blue, _circle.X, _circle.Y, _circle.Radius);

            // Highlight the closest point on the line
            SplashKit.FillCircle(Color.Green, closestPoint.X, closestPoint.Y, 5);

            SplashKit.RefreshScreen();
        }
    }

    // Method to calculate the closest point on the line from the circle
    private Point2D GetClosestPointOnLine(Circle circle, Line line)
    {
        // Calculate the vector for the line
        double dx = line.EndPoint.X - line.StartPoint.X;
        double dy = line.EndPoint.Y - line.StartPoint.Y;

        // Calculate the projection factor for the closest point
        double t = ((circle.X - line.StartPoint.X) * dx + (circle.Y - line.StartPoint.Y) * dy) / (dx * dx + dy * dy);

        // Clamp t to the range [0, 1] to keep the point on the line segment
        t = Math.Max(0, Math.Min(1, t));

        // Calculate the closest point on the line
        double closestX = line.StartPoint.X + t * dx;
        double closestY = line.StartPoint.Y + t * dy;

        return new Point2D(closestX, closestY);
    }
}

public static class Program
{
    public static void Main()
    {
        CircleClosetPoint tracker = new CircleClosetPoint();
        tracker.Run();
    }
}
