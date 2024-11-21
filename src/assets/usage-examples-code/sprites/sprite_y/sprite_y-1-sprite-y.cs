using SplashKitSDK;
using static SplashKitSDK.SplashKit;

Window gameWindow = new Window("spriteY", 600, 600);

Bitmap playerBitmap = LoadBitmap("player", "player-run.png");
Sprite playerSprite = CreateSprite(playerBitmap);

// Set the x and y coordinate in reference to the window
SpriteSetX(playerSprite, 300);
SpriteSetY(playerSprite, 300);

// retrieve the y position using the spriteX function
double yPosition = SpriteY(playerSprite);

ClearScreen(Color.Black);
DrawSprite(playerSprite);

DrawText("Sprite Y: " + yPosition.ToString(), Color.White, 10, 10);

RefreshScreen();
Delay(5000);

gameWindow.Close();