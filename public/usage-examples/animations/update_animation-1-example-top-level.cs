using SplashKitSDK;

OpenWindow("Animation Frame Updates", 800, 600);

// Load animation script and bitmap
AnimationScript coinScript = LoadAnimationScript("spinning_coin", "coin.txt");
Bitmap coinBmp = LoadBitmap("coin", "coin.png");
BitmapSetCellDetails(coinBmp, 32, 32, 8, 1, 8); // 8 frames of spinning coin

// Create animation
Animation coinSpin = CreateAnimation(coinScript, "spin");

Point2D coinPos = PointAt(400, 300);

while (!QuitRequested())
{
    ProcessEvents();
    
    // Update animation with different speeds based on keyboard input
    if (KeyDown(KeyCode.SpaceKey))
    {
        // Fast animation - update with 2x speed
        UpdateAnimation(coinSpin, 2.0f);
    }
    else if (KeyDown(KeyCode.LeftShiftKey))
    {
        // Slow animation - update with 0.5x speed
        UpdateAnimation(coinSpin, 0.5f);
    }
    else
    {
        // Normal animation speed
        UpdateAnimation(coinSpin);
    }
    
    ClearScreen(Color.DarkBlue);
    
    // Draw spinning coin
    DrawBitmap(coinBmp, coinPos.X - 16, coinPos.Y - 16, 
               OptionWithAnimation(coinSpin));
    
    // Draw instructions and animation info
    DrawText("Spinning Coin Animation", Color.White, 10, 10);
    DrawText("SPACE: Fast, SHIFT: Slow, Normal: Default", Color.White, 10, 30);
    DrawText($"Current Frame: {AnimationCurrentCell(coinSpin)}", 
             Color.White, 10, 50);
    DrawText($"Frame Time: {AnimationFrameTime(coinSpin):F2}", 
             Color.White, 10, 70);
    DrawText($"Animation Ended: {(AnimationEnded(coinSpin) ? "Yes" : "No")}", 
             Color.White, 10, 90);
    
    RefreshScreen(60);
}

// Clean up
FreeAnimation(coinSpin);
FreeAnimationScript(coinScript);
FreeBitmap(coinBmp);
CloseAllWindows();
