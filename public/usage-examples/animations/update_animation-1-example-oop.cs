using SplashKitSDK;

Program.Main();

public static class Program
{
    public static void Main()
    {
        SplashKit.OpenWindow("Animation Frame Updates", 800, 600);
        
        // Load animation script and bitmap
        AnimationScript coinScript = SplashKit.LoadAnimationScript("spinning_coin", "coin.txt");
        Bitmap coinBmp = SplashKit.LoadBitmap("coin", "coin.png");
        SplashKit.BitmapSetCellDetails(coinBmp, 32, 32, 8, 1, 8); // 8 frames of spinning coin
        
        // Create animation
        Animation coinSpin = SplashKit.CreateAnimation(coinScript, "spin");
        
        Point2D coinPos = SplashKit.PointAt(400, 300);
        
        while (!SplashKit.QuitRequested())
        {
            SplashKit.ProcessEvents();
            
            // Update animation with different speeds based on keyboard input
            if (SplashKit.KeyDown(KeyCode.SpaceKey))
            {
                // Fast animation - update with 2x speed
                SplashKit.UpdateAnimation(coinSpin, 2.0f);
            }
            else if (SplashKit.KeyDown(KeyCode.LeftShiftKey))
            {
                // Slow animation - update with 0.5x speed
                SplashKit.UpdateAnimation(coinSpin, 0.5f);
            }
            else
            {
                // Normal animation speed
                SplashKit.UpdateAnimation(coinSpin);
            }
            
            SplashKit.ClearScreen(Color.DarkBlue);
            
            // Draw spinning coin
            SplashKit.DrawBitmap(coinBmp, coinPos.X - 16, coinPos.Y - 16, 
                               SplashKit.OptionWithAnimation(coinSpin));
            
            // Draw instructions and animation info
            SplashKit.DrawText("Spinning Coin Animation", Color.White, 10, 10);
            SplashKit.DrawText("SPACE: Fast, SHIFT: Slow, Normal: Default", Color.White, 10, 30);
            SplashKit.DrawText($"Current Frame: {SplashKit.AnimationCurrentCell(coinSpin)}", 
                             Color.White, 10, 50);
            SplashKit.DrawText($"Frame Time: {SplashKit.AnimationFrameTime(coinSpin):F2}", 
                             Color.White, 10, 70);
            SplashKit.DrawText($"Animation Ended: {(SplashKit.AnimationEnded(coinSpin) ? "Yes" : "No")}", 
                             Color.White, 10, 90);
            
            SplashKit.RefreshScreen(60);
        }
        
        // Clean up
        SplashKit.FreeAnimation(coinSpin);
        SplashKit.FreeAnimationScript(coinScript);
        SplashKit.FreeBitmap(coinBmp);
        SplashKit.CloseAllWindows();
    }
}
