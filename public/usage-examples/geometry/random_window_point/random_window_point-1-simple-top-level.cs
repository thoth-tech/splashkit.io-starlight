using SplashKitSDK;
using static SplashKitSDK.SplashKit;

//Create Window
Window window = OpenWindow("portal", 600, 600);

// load portal sprites
LoadBitmap("bluePortal", "bluePortal.png");
LoadBitmap("orangePortal", "orangePortal.png");
Sprite blue_portal = CreateSprite(BitmapNamed("bluePortal"));
Sprite orange_portal = CreateSprite(BitmapNamed("orangePortal"));


//set random portal location
SpriteSetPosition(blue_portal, RandomWindowPoint(window));
SpriteSetPosition(orange_portal, RandomWindowPoint(window));

ClearWindow(window, ColorBlack());

//Draw the sprite
DrawSprite(blue_portal);
DrawSprite(orange_portal);

RefreshScreen();
Delay(5000);
CloseAllWindows();
