using SplashKitSDK;
using static SplashKitSDK.SplashKit;

//Create Window
OpenWindow("draw sprite random", 600, 600);

LoadBitmap("food", "food.png");
Sprite FoodSprite = CreateSprite(BitmapNamed("food"));

//set random food location
SpriteSetPosition(FoodSprite, RandomScreenPoint());


ClearScreen(ColorBlack());

//Draw the sprite
DrawSprite(FoodSprite);

RefreshScreen();
Delay(5000);
CloseAllWindows();
