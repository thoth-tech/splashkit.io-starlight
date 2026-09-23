using SplashKitSDK;

namespace MoveCameraToExample
{
    public class Program
    {
        public static void Main()
        {
            const int screenWidth = 800;
            const int screenHeight = 600;
            const int worldWidth = 1600;
            const int worldHeight = 1000;

            const double playerSize = 40;
            const double movementSpeed = 5;

            SplashKit.OpenWindow(
                "Move Camera To Example",
                screenWidth,
                screenHeight
            );

            double playerX = 380;
            double playerY = 280;

            while (!SplashKit.QuitRequested())
            {
                SplashKit.ProcessEvents();

                if (
                    SplashKit.KeyDown(KeyCode.LeftKey) ||
                    SplashKit.KeyDown(KeyCode.AKey)
                )
                {
                    playerX -= movementSpeed;
                }

                if (
                    SplashKit.KeyDown(KeyCode.RightKey) ||
                    SplashKit.KeyDown(KeyCode.DKey)
                )
                {
                    playerX += movementSpeed;
                }

                if (
                    SplashKit.KeyDown(KeyCode.UpKey) ||
                    SplashKit.KeyDown(KeyCode.WKey)
                )
                {
                    playerY -= movementSpeed;
                }

                if (
                    SplashKit.KeyDown(KeyCode.DownKey) ||
                    SplashKit.KeyDown(KeyCode.SKey)
                )
                {
                    playerY += movementSpeed;
                }

                // Keep the player within the world.
                if (playerX < 0)
                {
                    playerX = 0;
                }

                if (playerX > worldWidth - playerSize)
                {
                    playerX = worldWidth - playerSize;
                }

                if (playerY < 0)
                {
                    playerY = 0;
                }

                if (playerY > worldHeight - playerSize)
                {
                    playerY = worldHeight - playerSize;
                }

                // Centre the camera on the player.
                double cameraX =
                    playerX + playerSize / 2 - screenWidth / 2.0;

                double cameraY =
                    playerY + playerSize / 2 - screenHeight / 2.0;

                // Keep the camera within the world.
                if (cameraX < 0)
                {
                    cameraX = 0;
                }

                if (cameraX > worldWidth - screenWidth)
                {
                    cameraX = worldWidth - screenWidth;
                }

                if (cameraY < 0)
                {
                    cameraY = 0;
                }

                if (cameraY > worldHeight - screenHeight)
                {
                    cameraY = worldHeight - screenHeight;
                }

                // Move the camera to the calculated world position.
                SplashKit.MoveCameraTo(cameraX, cameraY);

                SplashKit.ClearScreen(
                    SplashKit.ColorWhite()
                );

                // Draw a simple grid to show camera movement.
                for (int x = 0; x <= worldWidth; x += 200)
                {
                    SplashKit.DrawLine(
                        SplashKit.ColorLightGray(),
                        x,
                        0,
                        x,
                        worldHeight
                    );
                }

                for (int y = 0; y <= worldHeight; y += 200)
                {
                    SplashKit.DrawLine(
                        SplashKit.ColorLightGray(),
                        0,
                        y,
                        worldWidth,
                        y
                    );
                }

                // Draw simple landmarks within the world.
                SplashKit.FillRectangle(
                    SplashKit.ColorGreen(),
                    100,
                    100,
                    180,
                    120
                );

                SplashKit.FillCircle(
                    SplashKit.ColorRed(),
                    800,
                    450,
                    70
                );

                SplashKit.FillRectangle(
                    SplashKit.ColorOrange(),
                    1300,
                    750,
                    180,
                    120
                );

                // Draw the world boundary and player.
                SplashKit.DrawRectangle(
                    SplashKit.ColorBlack(),
                    0,
                    0,
                    worldWidth,
                    worldHeight
                );

                SplashKit.FillRectangle(
                    SplashKit.ColorBlue(),
                    playerX,
                    playerY,
                    playerSize,
                    playerSize
                );

                SplashKit.RefreshScreen(60);
            }

            SplashKit.CloseAllWindows();
        }
    }
}