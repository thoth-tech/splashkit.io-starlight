/*
    Usage Example: freeing a sprite
*/

using System;
using SplashKitSDK;

public class Program
{
    public static void Main()
    {
        // Window to draw the sprite on
        Window start = SplashKit.OpenWindow("create_sprite", 600, 600);

        // Bitmap for creating a sprite
        Bitmap player = SplashKit.LoadBitmap("playerBmp", "protSpriteSheet.png");
        player.SetCellDetails(31, 32, 4, 3, 12);

        // Creating the player sprite
        Sprite playerSprite = SplashKit.CreateSprite(player);

        // Setting the coordinates in reference to the window
        playerSprite.X = 300;
        playerSprite.Y = 300;

        // Creating game loop
        while (!SplashKit.QuitRequested())
        {
            SplashKit.ProcessEvents();
            SplashKit.ClearScreen(Color.Black);
            SplashKit.DrawSprite(playerSprite);
            SplashKit.RefreshScreen();

            // If up key is typed, the sprite is removed
            if (SplashKit.KeyTyped(KeyCode.UpKey))
            {
                SplashKit.FreeSprite(playerSprite);
            }

            SplashKit.UpdateSprite(playerSprite);
        }

        start.Close();
    }
}