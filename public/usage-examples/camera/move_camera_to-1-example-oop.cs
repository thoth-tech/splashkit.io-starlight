using SplashKitSDK;

namespace MoveCameraToExample
{
    public class Program
    {
        public static void Main()
        {
            // Open a window
            Window window = SplashKit.OpenWindow("Move Camera To Example", 800, 600);

            // Create a player bitmap and sprite
            Bitmap playerBmp = SplashKit.CreateBitmap("player", 40, 40);
            playerBmp.Clear(Color.BrightGreen);
            Sprite player = SplashKit.CreateSprite(playerBmp);

            // Position the player further out in the game world
            player.X = 1000;
            player.Y = 1000;

            while (!window.CloseRequested)
            {
                // Handle input to move the player
                SplashKit.ProcessEvents();

                if (SplashKit.KeyDown(KeyCode.LeftKey)) player.X -= 5;
                if (SplashKit.KeyDown(KeyCode.RightKey)) player.X += 5;
                if (SplashKit.KeyDown(KeyCode.UpKey)) player.Y -= 5;
                if (SplashKit.KeyDown(KeyCode.DownKey)) player.Y += 5;

                // Center camera on player when SPACE is pressed
                if (SplashKit.KeyTyped(KeyCode.SpaceKey))
                {
                    // Calculate the top-left position for the camera to center the player
                    double targetX = player.X + player.Width / 2 - SplashKit.ScreenWidth() / 2;
                    double targetY = player.Y + player.Height / 2 - SplashKit.ScreenHeight() / 2;

                    // Move the camera to the calculated point
                    SplashKit.MoveCameraTo(targetX, targetY);
                }

                // Reset camera to origin when M is pressed
                if (SplashKit.KeyTyped(KeyCode.MKey))
                {
                    SplashKit.MoveCameraTo(0, 0);
                }

                // Clear the screen
                window.Clear(Color.Black);

                // Draw some world markers to visualize the camera move
                window.FillRectangle(Color.White, 0, 0, 20, 20);
                window.DrawText("World (0,0)", Color.White, 5, 25);

                window.FillRectangle(Color.Red, 1000, 1000, 20, 20);
                window.DrawText("World (1000,1000)", Color.Red, 1000, 1025);

                // Draw the sprite (automatically uses camera offset)
                player.Draw();

                // Draw HUD (Heads-Up Display) directly to the screen
                window.FillRectangle(Color.DimGray, 0, 0, 260, 80, SplashKit.OptionToScreen());
                window.DrawText($"Camera Position: {SplashKit.PointToString(Camera.Position)}", Color.White, 10, 10, SplashKit.OptionToScreen());
                window.DrawText($"Player World Pos: ({(int)player.X}, {(int)player.Y})", Color.White, 10, 30, SplashKit.OptionToScreen());
                window.DrawText("Press SPACE to center on player", Color.White, 10, 50, SplashKit.OptionToScreen());
                window.DrawText("Press M to move camera to (0,0)", Color.White, 10, 65, SplashKit.OptionToScreen());

                window.Refresh(60);
            }

            SplashKit.CloseAllWindows();
        }
    }
}
