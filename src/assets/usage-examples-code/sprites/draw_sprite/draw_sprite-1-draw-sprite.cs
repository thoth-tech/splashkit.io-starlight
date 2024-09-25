using System;
using SplashKitSDK;
using static SplashKitSDK.SplashKit;

// window to draw the sprite on
Window start = OpenWindow("draw_sprite", 600, 600);

// bitmap for creating a sprite
Bitmap player = LoadBitmap("player_bitmap", "player.png");
player.SetCellDetails(31, 32, 4, 3, 12);

// creating the player sprite
Sprite playerSprite = CreateSprite(player);

// setting the coordinates in reference to the window
playerSprite.X = 300;
playerSprite.Y = 300;

// clearing the screen
ClearScreen(Color.Black);

// drawing the sprite
DrawSprite(playerSprite);

RefreshScreen();
Delay(10000);

CloseWindow(start);