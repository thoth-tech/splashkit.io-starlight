using SplashKitSDK;


// Window to draw the sprite on
Window start = new Window("sprite_set_position", 600, 600);

// Bitmap for creating a sprite
Bitmap player = new Bitmap("playerBmp", "protSpriteSheet-R.png");

// Creating the player sprite
Sprite playerSprite = new Sprite(player);

// Setting the x and y coordinates in reference to the window
playerSprite.X = 200;
playerSprite.Y = 300;

SplashKit.ClearScreen(Color.Black);
playerSprite.Draw();
SplashKit.RefreshScreen();
SplashKit.Delay(4000);

// Point2D object which stores the new coordinates
Point2D pos = SplashKit.PointAt(450, 300);

// Set the new sprite position
playerSprite.Position = pos;
SplashKit.ClearScreen(Color.Black);
playerSprite.Draw();
SplashKit.RefreshScreen();
SplashKit.Delay(10000);

// Closing the window
start.Close();