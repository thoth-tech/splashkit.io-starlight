using SplashKitSDK;
using static SplashKitSDK.SplashKit;

OpenWindow("Sprite Pack Simulation", 800, 600);

// Load the bitmaps for creating sprites
Bitmap gliese = LoadBitmap("gliese", "Gliese.png");
Bitmap aquarii = LoadBitmap("aquarii", "Aquarii.png");

// Create the sprites
Sprite glieseSprite = CreateSprite(gliese);
Sprite aquariiSprite = CreateSprite(aquarii);

// Set starting position (center)
SpriteSetX(glieseSprite, 400);
SpriteSetY(glieseSprite, 300);
SpriteSetX(aquariiSprite, 400);
SpriteSetY(aquariiSprite, 300);

// Active sprite flag (true = Gliese, false = Aquarii)
bool useGliese = true;

while (!QuitRequested())
{
    ProcessEvents();

    // Switch control with keys
    if (KeyTyped(KeyCode.Num1Key)) useGliese = true;
    if (KeyTyped(KeyCode.Num2Key)) useGliese = false;

    // Move the active sprite (left/right arrows)
    if (useGliese)
    {
        if (KeyDown(KeyCode.LeftKey)) SpriteSetX(glieseSprite, SpriteX(glieseSprite) - 5);
        if (KeyDown(KeyCode.RightKey)) SpriteSetX(glieseSprite, SpriteX(glieseSprite) + 5);
    }
    else
    {
        if (KeyDown(KeyCode.LeftKey)) SpriteSetX(aquariiSprite, SpriteX(aquariiSprite) - 5);
        if (KeyDown(KeyCode.RightKey)) SpriteSetX(aquariiSprite, SpriteX(aquariiSprite) + 5);
    }

    ClearScreen(ColorBlack());
    if (useGliese)
    {
        DrawSprite(glieseSprite);
        DrawText("Active: Gliese (Press 2 for Aquarii)", ColorWhite(), 10, 10);
    }
    else
    {
        DrawSprite(aquariiSprite);
        DrawText("Active: Aquarii (Press 1 for Gliese)", ColorWhite(), 10, 10);
    }
    DrawText("Use LEFT/RIGHT arrows to move", ColorWhite(), 10, 40);

    RefreshScreen();
}

CloseAllWindows();
