using SplashKitSDK;


// Open a window to draw the sprite on
Window start = SplashKit.OpenWindow("sprite-set-velocity", 600, 600);

// Load bitmap for creating a sprite
Bitmap player = SplashKit.LoadBitmap("playerBmp", "protSpriteSheet-R.png");

// Create the player sprite
Sprite playerSprite = SplashKit.CreateSprite(player);

// Set the coordinates in reference to the window
SplashKit.SpriteSetX(playerSprite, 300);
SplashKit.SpriteSetY(playerSprite, 300);

// Create vector for sprite's velocity
Vector2D vel = new Vector2D();
vel.X = 0.01;
vel.Y = 0;

// Game loop
while (!SplashKit.WindowCloseRequested(start))
{
    SplashKit.ProcessEvents();
    SplashKit.ClearScreen(Color.Black);
    // set sprite velocity
    SplashKit.SpriteSetVelocity(playerSprite, vel);
    SplashKit.DrawSprite(playerSprite);
    SplashKit.UpdateSprite(playerSprite);

    SplashKit.RefreshScreen();
}

SplashKit.CloseWindow(start);