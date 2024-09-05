using SplashKitSDK;


// Window to draw the sprite on
Window start = new Window("sprite_set_y", 600, 600);

// Bitmap for creating a sprite
Bitmap player = new Bitmap("playerBmp", "protSpriteSheet-R.png");
player.SetCellDetails(31, 32, 4, 3, 12);

// Creating the player sprite
Sprite playerSprite = new Sprite(player);

// Setting the x coordinates in reference to the window
playerSprite.Y = 300;

SplashKit.ClearScreen(Color.Black);
playerSprite.Draw();
SplashKit.RefreshScreen();
SplashKit.Delay(10000);

// close the window
start.Close();
