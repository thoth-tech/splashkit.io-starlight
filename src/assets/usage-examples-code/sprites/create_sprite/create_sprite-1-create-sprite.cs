/*
    usage example: creating a sprite
*/

using System;
using SplashKitSDK;

// window to draw the sprite on
Window start = SplashKit.OpenWindow("create_sprite", 600, 600);

// bitmap for creating a sprite
Bitmap player = SplashKit.LoadBitmap("playerBmp", "protSpriteSheet.png");
player.SetCellDetails(31, 32, 4, 3, 12);

// creating the player sprite
Sprite playerSprite = SplashKit.CreateSprite(player);

// setting the coordinates in reference to the window
playerSprite.X = 300;
playerSprite.Y = 300;

// clearing the screen
SplashKit.ClearScreen(Color.Black);

// drawing the sprite
SplashKit.DrawSprite(playerSprite);

SplashKit.RefreshScreen();
SplashKit.Delay(10000);

start.Close();

