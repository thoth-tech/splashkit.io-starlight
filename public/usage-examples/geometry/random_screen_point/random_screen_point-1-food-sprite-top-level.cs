using SplashKitSDK;
using static SplashKitSDK.SplashKit;

// Create Window
OpenWindow("Food Generator", 600, 600);

LoadBitmap("Food", "food.png");
Sprite FoodSprite = CreateSprite(BitmapNamed("Food"));

// Set random food location
SpriteSetPosition(FoodSprite, RandomScreenPoint());

ClearScreen(ColorBlack());

// Draw the sprite
DrawSprite(FoodSprite);

RefreshScreen();
Delay(5000);
CloseAllWindows();
