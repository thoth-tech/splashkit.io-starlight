using SplashKitSDK;
using static SplashKitSDK.SplashKit;

OpenWindow("Move Sprite To Example", 600, 600);

SplashKitSDK.Bitmap playerBitmap = LoadBitmap("player_bitmap", "player.png");
SplashKitSDK.Sprite playerSprite = CreateSprite(playerBitmap);

SpriteSetPosition(playerSprite, PointAt(100, 300));

while (!QuitRequested())
{
    ProcessEvents();

    // Move the sprite toward the position clicked by the user.
    if (MouseClicked(SplashKitSDK.MouseButton.LeftButton))
    {
        MoveSpriteTo(playerSprite, MouseX(), MouseY());
    }

    UpdateSprite(playerSprite);

    ClearScreen(ColorBlack());
    DrawText("Click anywhere to move the sprite", ColorWhite(), 150, 40);
    DrawSprite(playerSprite);
    RefreshScreen(60);
}

FreeSprite(playerSprite);
FreeBitmap(playerBitmap);