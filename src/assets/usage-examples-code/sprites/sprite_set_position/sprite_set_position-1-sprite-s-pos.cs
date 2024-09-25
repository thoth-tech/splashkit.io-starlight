using SplashKitSDK;
using static SplashKitSDK.SplashKit;

// Window to draw the sprite on
Window start = new Window("spriteSetPosition", 600, 600);

// Bitmap for creating a sprite
Bitmap player = new Bitmap("playerBmp", "player-run.png");

// Creating the player sprite
Sprite playerSprite = new Sprite(player);

// Setting the x and y coordinates in reference to the window
SpriteSetX(playerSprite, 200);
SpriteSetY(playerSprite, 300);

ClearScreen(Color.Black);
playerSprite.Draw();
RefreshScreen();
Delay(4000);

// Point2D object which stores the new coordinates
Point2D pos = PointAt(450, 300);

// Set the new sprite position using SpriteSetPosition and the Point2D object
SpriteSetPosition(playerSprite, pos);

ClearScreen(Color.Black);
playerSprite.Draw();
RefreshScreen();
Delay(10000);

// Closing the window
start.Close();