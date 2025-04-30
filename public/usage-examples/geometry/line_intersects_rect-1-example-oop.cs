using SplashKitSDK;

public class Program
{
    public static void Main()
    {
        // Open a window
        Window window = SplashKit.OpenWindow("Line Intersects Rect", 800, 600);

        // Define a draggable line
        Point2D startPt = new Point2D() { X = 100, Y = 100 };
        Point2D endPt = new Point2D() { X = 700, Y = 500 };
        Line line = SplashKit.LineFrom(startPt, endPt);

        // Define a static rectangle
        Rectangle rect = new Rectangle()
        {
            X = 300,
            Y = 200,
            Width = 200,
            Height = 150
        };

        // Run until the user closes the window
        while (!window.CloseRequested)
        {
            SplashKit.ProcessEvents();

            // Move the line ends with mouse
            if (SplashKit.MouseDown(MouseButton.LeftButton))
            {
                if (SplashKit.PointInCircle(SplashKit.MousePosition(), SplashKit.CircleAt(startPt, 10)))
                {
                    startPt = SplashKit.MousePosition();
                }
                else if (SplashKit.PointInCircle(SplashKit.MousePosition(), SplashKit.CircleAt(endPt, 10)))
                {
                    endPt = SplashKit.MousePosition();
                }
            }

            // Update line with new points
            line = SplashKit.LineFrom(startPt, endPt);

            // Check for intersection
            bool intersects = SplashKit.LineIntersectsRect(line, rect);

            SplashKit.ClearScreen(Color.White);

            // Draw the rectangle
            SplashKit.DrawRectangle(Color.Blue, rect);

            // Draw the line
            SplashKit.DrawLine(Color.Black, line);

            // Draw small circles at line endpoints for dragging
            SplashKit.DrawCircle(Color.Green, startPt.X, startPt.Y, 5);
            SplashKit.DrawCircle(Color.Green, endPt.X, endPt.Y, 5);

            // Show text if intersecting
            if (intersects)
            {
                SplashKit.DrawText("Intersecting", Color.Red, "Arial", 20, 10, 10);
            }

            SplashKit.RefreshScreen();
        }
    }
}
