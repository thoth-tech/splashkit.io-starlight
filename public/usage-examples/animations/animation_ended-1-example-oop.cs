using SplashKitSDK;

Program.Main();

public static class Program
{
    public static void Main()
    {
        SplashKit.OpenWindow("Animation End Detection", 800, 600);
        
        // Load animation script and bitmap for explosion effect
        AnimationScript explosionScript = SplashKit.LoadAnimationScript("explosion", "explosion.txt");
        Bitmap explosionBmp = SplashKit.LoadBitmap("explosion", "explosion.png");
        SplashKit.BitmapSetCellDetails(explosionBmp, 64, 64, 5, 5, 25); // 5x5 grid, 25 frames
        
        // Create animation that plays once
        Animation explosionAnim = SplashKit.CreateAnimation(explosionScript, "explode");
        
        Point2D explosionPos = SplashKit.PointAt(400, 300);
        bool showExplosion = false;
        
        while (!SplashKit.QuitRequested())
        {
            SplashKit.ProcessEvents();
            
            // Press SPACE to trigger explosion
            if (SplashKit.KeyTyped(KeyCode.SpaceKey))
            {
                SplashKit.RestartAnimation(explosionAnim);
                showExplosion = true;
            }
            
            if (showExplosion)
            {
                SplashKit.UpdateAnimation(explosionAnim);
                
                // Check if animation has ended
                if (SplashKit.AnimationEnded(explosionAnim))
                {
                    showExplosion = false;
                }
            }
            
            SplashKit.ClearScreen(Color.Black);
            
            // Draw explosion if active
            if (showExplosion)
            {
                SplashKit.DrawBitmap(explosionBmp, explosionPos.X - 32, explosionPos.Y - 32,
                                   SplashKit.OptionWithAnimation(explosionAnim));
            }
            
            // Draw instructions and status
            SplashKit.DrawText("Press SPACE to trigger explosion", Color.White, 10, 10);
            SplashKit.DrawText($"Explosion Active: {(showExplosion ? "Yes" : "No")}", 
                             Color.White, 10, 30);
            SplashKit.DrawText($"Animation Ended: {(SplashKit.AnimationEnded(explosionAnim) ? "Yes" : "No")}", 
                             Color.White, 10, 50);
            SplashKit.DrawText($"Current Frame: {SplashKit.AnimationCurrentCell(explosionAnim)}", 
                             Color.White, 10, 70);
            
            SplashKit.RefreshScreen(60);
        }
        
        // Clean up
        SplashKit.FreeAnimation(explosionAnim);
        SplashKit.FreeAnimationScript(explosionScript);
        SplashKit.FreeBitmap(explosionBmp);
        SplashKit.CloseAllWindows();
    }
}
