using SplashKitSDK;
using static SplashKitSDK.SplashKit; 

// Open a window to draw the sprite on
Window start = OpenWindow("create_sprite", 600, 600);

// Load the bitmap for creating a sprite
Bitmap player = LoadBitmap("playerBmp", "protSpriteSheet.png");
player.SetCellDetails(31, 32, 4, 3, 12);

// Create the player sprite
Sprite playerSprite = CreateSprite(player);

// Set the sprite coordinates in reference to the window
playerSprite.X = 300;
playerSprite.Y = 300;

// Clear the screen
ClearScreen(Color.Black);

// Draw the sprite
DrawSprite(playerSprite);

// Refresh the screen and delay to keep the window open
RefreshScreen();
Delay(10000);

// Close the window
start.Close();

