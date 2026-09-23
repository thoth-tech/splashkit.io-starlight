using static SplashKitSDK.SplashKit;
using SplashKitSDK;

// Open a new window
OpenWindow("Sprite Circle Collision", 540, 380);

// Load the bitmap and create the sprite
Bitmap spriteBitmap = LoadBitmap("player", "skbox.png");
Sprite player = CreateSprite(spriteBitmap);

// Position the sprite
Point2D spritePosition = PointAt(70, 90);
SpriteSetPosition(player, spritePosition);

// Define the circles
Circle collisionCircle = CircleAt(120, 140, 70);
Circle clearCircle = CircleAt(460, 290, 40);

// Clear the screen and draw the example
ClearScreen(ColorWhite());

FillCircle(ColorGreen(), collisionCircle);
FillCircle(ColorRed(), clearCircle);
DrawSprite(player);

// Check the collisions
if (SpriteCircleCollision(player, collisionCircle))
{
    WriteLine("Green Circle Collision");
}

if (!SpriteCircleCollision(player, clearCircle))
{
    WriteLine("No Red Circle Collision");
}

// Display the result briefly
RefreshScreen();
Delay(4000);

CloseAllWindows();
