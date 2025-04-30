using System;
using SplashKitSDK;

namespace DodgeBouncingBalls
{
    class Program
    {
        static void Main()
        {
            // Open the gameplay window 
            Window window = SplashKit.OpenWindow("Dodge the Bouncing Balls", 800, 600);

            // Initialize player and enemy circles 
            Circle playerCircle = SplashKit.CircleAt(400, 300, 20);
            Circle enemyCircle1 = SplashKit.CircleAt(100, 100, 30);
            Circle enemyCircle2 = SplashKit.CircleAt(700, 500, 30);

            // Assign initial velocities to make enemies bounce off the window edges
            double dx1 = 3, dy1 = 2;
            double dx2 = -2, dy2 = -3;

            // Run the main game loop until the player quits or a collision occurs
            while (!SplashKit.WindowCloseRequested(window))
            {
                SplashKit.ProcessEvents();

                // Update player position based on arrow key inputs
                if (SplashKit.KeyDown(KeyCode.LeftKey))
                {
                    playerCircle.Center.X -= 5;
                }
                if (SplashKit.KeyDown(KeyCode.RightKey))
                {
                    playerCircle.Center.X += 5;
                }
                if (SplashKit.KeyDown(KeyCode.UpKey))
                {
                    playerCircle.Center.Y -= 5;
                }
                if (SplashKit.KeyDown(KeyCode.DownKey))
                {
                    playerCircle.Center.Y += 5;
                }

                // Move enemy 1 and bounce off the edges of the window
                enemyCircle1.Center.X += dx1;
                enemyCircle1.Center.Y += dy1;
                if (enemyCircle1.Center.X < enemyCircle1.Radius || enemyCircle1.Center.X > SplashKit.ScreenWidth() - enemyCircle1.Radius)
                {
                    dx1 = -dx1;
                }
                if (enemyCircle1.Center.Y < enemyCircle1.Radius || enemyCircle1.Center.Y > SplashKit.ScreenHeight() - enemyCircle1.Radius)
                {
                    dy1 = -dy1;
                }

                // Move enemy 2 and bounce off the edges of the window
                enemyCircle2.Center.X += dx2;
                enemyCircle2.Center.Y += dy2;
                if (enemyCircle2.Center.X < enemyCircle2.Radius || enemyCircle2.Center.X > SplashKit.ScreenWidth() - enemyCircle2.Radius)
                {
                    dx2 = -dx2;
                }
                if (enemyCircle2.Center.Y < enemyCircle2.Radius || enemyCircle2.Center.Y > SplashKit.ScreenHeight() - enemyCircle2.Radius)
                {
                    dy2 = -dy2;
                }

                // Render player and enemy circles on screen
                SplashKit.ClearScreen(Color.White);
                SplashKit.FillCircle(Color.Green, playerCircle);
                SplashKit.FillCircle(Color.Red, enemyCircle1);
                SplashKit.FillCircle(Color.Red, enemyCircle2);
                SplashKit.RefreshScreen(60);

                // Display "Game Over" and exit if a collision is detected
                if (SplashKit.CirclesIntersect(playerCircle, enemyCircle1) ||
                    SplashKit.CirclesIntersect(playerCircle, enemyCircle2))
                {
                    SplashKit.ClearScreen(Color.White);
                    SplashKit.DrawText("Game Over", Color.Black, 350, 280);
                    SplashKit.RefreshScreen(60);
                    SplashKit.Delay(2000);
                    break;
                }
            }
        }
    }
}
