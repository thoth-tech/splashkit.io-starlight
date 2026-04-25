using SplashKitSDK;

namespace AngleBetweenExample
{
    public class Program
    {
        public static void Main()
        {
            SplashKit.OpenWindow("Angle Between Vectors", 800, 600);

            // Use one shared starting point for both vectors
            Point2D origin = SplashKit.PointAt(400, 300);

            // Create two vectors with different directions
            Vector2D firstVector = SplashKit.VectorTo(150, -100);
            Vector2D secondVector = SplashKit.VectorTo(200, 80);

            while (!SplashKit.QuitRequested())
            {
                SplashKit.ProcessEvents();

                // Calculate the angle from the first vector to the second vector
                double angle = SplashKit.AngleBetween(firstVector, secondVector);

                SplashKit.ClearScreen(Color.White);

                // Draw both vectors from the same origin point
                SplashKit.DrawLine(Color.Blue, origin.X, origin.Y, origin.X + firstVector.X, origin.Y + firstVector.Y);
                SplashKit.DrawLine(Color.Red, origin.X, origin.Y, origin.X + secondVector.X, origin.Y + secondVector.Y);

                // Label the vectors and show the calculated angle
                SplashKit.DrawText("Blue vector", Color.Blue, 520, 180);
                SplashKit.DrawText("Red vector", Color.Red, 560, 390);
                SplashKit.DrawText("Angle between vectors: " + angle.ToString("0.00") + " degrees", Color.Black, 180, 40);

                SplashKit.RefreshScreen(60);
            }

            SplashKit.CloseAllWindows();
        }
    }
}