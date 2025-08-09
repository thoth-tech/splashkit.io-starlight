using SplashKitSDK;

OpenWindow("Animation End Detection", 800, 600);

// Load animation script and bitmap for explosion effect
AnimationScript explosionScript = LoadAnimationScript("explosion", "explosion.txt");
Bitmap explosionBmp = LoadBitmap("explosion", "explosion.png");
BitmapSetCellDetails(explosionBmp, 64, 64, 5, 5, 25); // 5x5 grid, 25 frames

// Create animation that plays once
Animation explosionAnim = CreateAnimation(explosionScript, "explode");

Point2D explosionPos = PointAt(400, 300);
bool showExplosion = false;

while (!QuitRequested())
{
    ProcessEvents();
    
    // Press SPACE to trigger explosion
    if (KeyTyped(KeyCode.SpaceKey))
    {
        RestartAnimation(explosionAnim);
        showExplosion = true;
    }
    
    if (showExplosion)
    {
        UpdateAnimation(explosionAnim);
        
        // Check if animation has ended
        if (AnimationEnded(explosionAnim))
        {
            showExplosion = false;
        }
    }
    
    ClearScreen(Color.Black);
    
    // Draw explosion if active
    if (showExplosion)
    {
        DrawBitmap(explosionBmp, explosionPos.X - 32, explosionPos.Y - 32,
                   OptionWithAnimation(explosionAnim));
    }
    
    // Draw instructions and status
    DrawText("Press SPACE to trigger explosion", Color.White, 10, 10);
    DrawText($"Explosion Active: {(showExplosion ? "Yes" : "No")}", 
             Color.White, 10, 30);
    DrawText($"Animation Ended: {(AnimationEnded(explosionAnim) ? "Yes" : "No")}", 
             Color.White, 10, 50);
    DrawText($"Current Frame: {AnimationCurrentCell(explosionAnim)}", 
             Color.White, 10, 70);
    
    RefreshScreen(60);
}

// Clean up
FreeAnimation(explosionAnim);
FreeAnimationScript(explosionScript);
FreeBitmap(explosionBmp);
CloseAllWindows();
