using SplashKitSDK;

namespace AvoidTheObstacle
{
    public class Program
    {
        public static void Main()
        {
            Window window = new Window("Avoid the Obstacle", 600, 400);

            float playerX = 300, playerY = 200;
            const float playerRadius = 30;

            float obstacleX = 100, obstacleY = 100;
            const float obstacleRadius = 30;
            float obstacleSpeedX = 0.3f, obstacleSpeedY = 0.3f;

            while (!SplashKit.QuitRequested())
            {
                SplashKit.ProcessEvents();

                // Player movement
                if (SplashKit.KeyDown(KeyCode.UpKey)) playerY -= 0.5f;
                if (SplashKit.KeyDown(KeyCode.DownKey)) playerY += 0.5f;
                if (SplashKit.KeyDown(KeyCode.LeftKey)) playerX -= 0.5f;
                if (SplashKit.KeyDown(KeyCode.RightKey)) playerX += 0.5f;

                // Wall collision (soft boundaries)
                if (playerX - playerRadius < 0) playerX = playerRadius;
                if (playerX + playerRadius > 600) playerX = 600 - playerRadius;
                if (playerY - playerRadius < 0) playerY = playerRadius;
                if (playerY + playerRadius > 400) playerY = 400 - playerRadius;

                // Obstacle movement
                obstacleX += obstacleSpeedX;
                obstacleY += obstacleSpeedY;

                // Bounce off edges
                if (obstacleX - obstacleRadius < 0 || obstacleX + obstacleRadius > 600)
                    obstacleSpeedX *= -1;
                if (obstacleY - obstacleRadius < 0 || obstacleY + obstacleRadius > 400)
                    obstacleSpeedY *= -1;

                // Collision check
                if (SplashKit.CirclesIntersect(playerX, playerY, playerRadius, obstacleX, obstacleY, obstacleRadius))
                    SplashKit.ClearScreen(Color.Red);
                else
                    SplashKit.ClearScreen(Color.White);

                // Draw circles
                SplashKit.FillCircle(Color.Blue, playerX, playerY, playerRadius);
                SplashKit.FillCircle(Color.Red, obstacleX, obstacleY, obstacleRadius);

                SplashKit.RefreshScreen();
                SplashKit.Delay(10);
            }

            window.Close();
        }
    }
}
