using SplashKitSDK;

namespace RayCircleIntersectDistanceExample
{
    public class Program
    {
        public static void Main()
        {
            // Create a window
            Window window = new Window("Laser Collision with Circle", 800, 600);

            // Initialize player position
            Point2D playerPos = SplashKit.PointAt(0, 0);

            // Variables to store the latest shot data
            Point2D lastTarget = playerPos;
            Vector2D lastDirection = SplashKit.VectorTo(0, 0);
            float lastHitDistance = -1;

            // Define the target circle
            Circle targetCircle = new Circle()
            {
                Center = SplashKit.PointAt(400, 300),
                Radius = 100
            };

            while (!window.CloseRequested)
            {
                SplashKit.ProcessEvents();
                SplashKit.ClearScreen();

                // Draw the target circle
                SplashKit.DrawCircle(Color.Blue, targetCircle);

                // Fire a laser when the mouse is clicked
                if (SplashKit.MouseClicked(MouseButton.LeftButton))
                {
                    // Update the target position based on the mouse position
                    lastTarget = SplashKit.MousePosition();
                    lastDirection = SplashKit.UnitVector(SplashKit.VectorPointToPoint(playerPos, lastTarget));

                    // Check for intersection and calculate hit distance
                    lastHitDistance = SplashKit.RayCircleIntersectDistance(playerPos, lastDirection, targetCircle);
                }

                // If a shot has been made, draw the laser and hit point
                if (lastHitDistance >= 0)
                {
                    // Draw the laser beam
                    SplashKit.DrawLine(Color.Red, playerPos, lastTarget);

                    // Draw the impact point
                    if (lastHitDistance > 0)
                    {
                        SplashKit.FillCircle(Color.Green, playerPos.X + lastDirection.X * lastHitDistance, playerPos.Y + lastDirection.Y * lastHitDistance, 5);
                    }
                }

                // Refresh the screen
                SplashKit.RefreshScreen(60);
            }
        }
    }
}
