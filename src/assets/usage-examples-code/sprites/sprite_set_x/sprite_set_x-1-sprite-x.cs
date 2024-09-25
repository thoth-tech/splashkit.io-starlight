using SplashKitSDK;
using static SplashKitSDK.SplashKit;

// Window to draw the sprite on
Window start = new Window("sprite_set_x", 600, 600);

// Bitmap for creating a sprite
Bitmap player = new Bitmap("playerBmp", "player-run.png");
player.SetCellDetails(31, 32, 4, 3, 12);

// Creating the player sprite
Sprite playerSprite = new Sprite(player);

// Setting the x coordinates in reference to the window
playerSprite.X = 300;

ClearScreen(Color.Black);
playerSprite.Draw();
RefreshScreen();
Delay(10000);

// Close the window
start.Close();
