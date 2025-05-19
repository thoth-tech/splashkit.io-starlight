using SplashKitSDK;

namespace WidestPointsOnCircleExample
{
    public class Program
    {
        public static void Main()
        {
            SplashKit.OpenWindow("Widest points on a circle along a vector", 600, 600);

            // Create the circle at the center of the screen
            Point2D circleCenter = SplashKit.ScreenCenter();
            Circle circle = SplashKit.CircleAt(circleCenter, 100);

            Point2D mousePos;
            Vector2D directionVector;
            Point2D widestPoint1, widestPoint2;

            while (!SplashKit.QuitRequested())
            {
                SplashKit.ProcessEvents();

                // Get current mouse position
                mousePos = SplashKit.MousePosition();

                // Calculate the direction vector from the center to the mouse position
                directionVector = SplashKit.VectorPointToPoint(circle.Center, mousePos);

                // Calculate the widest points along the direction vector
                SplashKit.WidestPoints(circle, directionVector, out widestPoint1, out widestPoint2);

                // Draw everything
                SplashKit.ClearScreen();
                SplashKit.DrawCircle(Color.Black, circle);
                SplashKit.FillCircle(Color.Red, widestPoint1.X, widestPoint1.Y, 5);
                SplashKit.FillCircle(Color.Red, widestPoint2.X, widestPoint2.Y, 5);
                SplashKit.FillCircle(Color.Blue, mousePos.X, mousePos.Y, 5);
                SplashKit.DrawLine(Color.Green, circle.Center, mousePos);
                SplashKit.DrawLine(Color.Red, circle.Center, widestPoint1);
                SplashKit.DrawLine(Color.Red, circle.Center, widestPoint2);

                // Show calculation details
                SplashKit.DrawText(
                    $"Mouse Position (Vector Direction): ({(int)mousePos.X}, {(int)mousePos.Y})",
                    Color.Black, "Arial", 16, 10, 10);

                SplashKit.DrawText(
                    $"Widest Point 1: ({(int)widestPoint1.X}, {(int)widestPoint1.Y})",
                    Color.Black, "Arial", 16, 10, 35);

                SplashKit.DrawText(
                    $"Widest Point 2: ({(int)widestPoint2.X}, {(int)widestPoint2.Y})",
                    Color.Black, "Arial", 16, 10, 60);

                SplashKit.RefreshScreen();
            }

            SplashKit.CloseAllWindows();
        }
    }
}
