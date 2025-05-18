using SplashKitSDK;

namespace RayCircleIntersectDistanceExample
{
    public class Program
    {
        public static void Main()
        {
            SplashKit.OpenWindow("Ray-Circle Intersection Distance", 800, 600);

            // Declare variables
            Point2D rayOrigin = SplashKit.PointAt(0, 0);
            Circle targetCircle = SplashKit.CircleAt(400, 300, 100);
            Point2D mousePos;
            Vector2D rayHeading;
            float distanceToCircle;

            while (!SplashKit.QuitRequested())
            {
                SplashKit.ProcessEvents();

                // Calculate ray heading from origin to mouse
                mousePos = SplashKit.MousePosition();
                rayHeading = SplashKit.UnitVector(SplashKit.VectorPointToPoint(rayOrigin, mousePos));

                // Find intersection distance between ray and circle
                distanceToCircle = SplashKit.RayCircleIntersectDistance(rayOrigin, rayHeading, targetCircle);

                // Draw scene
                SplashKit.ClearScreen(Color.White);
                SplashKit.DrawCircle(Color.Blue, targetCircle);
                SplashKit.DrawLine(Color.Red, rayOrigin, mousePos);

                if (distanceToCircle > 0)
                {
                    Point2D hitPoint = SplashKit.PointAt(
                        rayOrigin.X + rayHeading.X * distanceToCircle,
                        rayOrigin.Y + rayHeading.Y * distanceToCircle
                    );
                    SplashKit.FillCircle(Color.Green, hitPoint.X, hitPoint.Y, 5);

                    // Display the distance
                    SplashKit.DrawText($"Distance to circle: {distanceToCircle}", Color.Black, 10, 10);
                }
                else
                {
                    // Display no intersection message
                    SplashKit.DrawText("No intersection", Color.Black, 10, 10);
                }

                SplashKit.RefreshScreen(60);
            }
        }
    }
}
