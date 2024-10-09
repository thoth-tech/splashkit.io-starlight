using SplashKitSDK;
using static SplashKitSDK.SplashKit;

Window gameWindow = new Window("sprite_x", 600, 600);

Bitmap playerBitmap = LoadBitmap("player", "player-run.png");
Sprite playerSprite = CreateSprite(playerBitmap);

// Set the x coordinate in reference to the window
SpriteSetX(playerSprite, 300);

// retrieve the x position using the spriteX function
double xPosition = SpriteX(playerSprite);

ClearScreen(Color.Black);
DrawSprite(playerSprite);

DrawText("Sprite X: " + xPosition.ToString(), Color.White, 10, 10);

RefreshScreen();
Delay(5000);

gameWindow.Close();