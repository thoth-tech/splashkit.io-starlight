using SplashKitSDK;

public class Program
{
    public static void Main()
    {
        Window window = new Window("Tangent Points Calculation", 800, 600);
        Circle circle = SplashKit.CircleAt(SplashKit.PointAt(400, 300), 100);

        while (!window.CloseRequested)
        {
            SplashKit.ProcessEvents();
            Point2D cursorPos = SplashKit.MousePosition();

            window.Clear(Color.White);

            // Draw the circle
            window.DrawCircle(Color.Black, circle);

            // Draw the external point (mouse)
            window.FillCircle(Color.Blue, cursorPos.X, cursorPos.Y, 5);

            // Display mouse coordinates
            window.DrawText(
                $"Mouse Position (External Point): ({(int)cursorPos.X}, {(int)cursorPos.Y})",
                Color.Black, "Arial", 16, 10, 10);

            // Calculate and draw tangent points if mouse is outside the circle
            Point2D tangent1, tangent2;
            if (SplashKit.TangentPoints(cursorPos, circle, out tangent1, out tangent2))
            {
                window.FillCircle(Color.Red, tangent1.X, tangent1.Y, 5);
                window.FillCircle(Color.Red, tangent2.X, tangent2.Y, 5);
                window.DrawLine(Color.Green, cursorPos, tangent1);
                window.DrawLine(Color.Green, cursorPos, tangent2);

                // Show tangent point coordinates
                window.DrawText($"Tangent 1: ({(int)tangent1.X}, {(int)tangent1.Y})",
                                Color.Black, "Arial", 16, 10, 35);
                window.DrawText($"Tangent 2: ({(int)tangent2.X}, {(int)tangent2.Y})",
                                Color.Black, "Arial", 16, 10, 60);
            }
            else
            {
                window.DrawText("Move the mouse outside the circle to see tangent points.",
                                Color.Black, "Arial", 16, 10, 35);
            }

            window.Refresh();
        }

        window.Close();
    }
}
