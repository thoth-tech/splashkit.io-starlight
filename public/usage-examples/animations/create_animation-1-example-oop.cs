using SplashKitSDK;

class Program
{
    static void Main(string[] args)
    {
        // Open a window
        SplashKit.OpenWindow("Animation Example", 800, 600);
        
        // Load a bitmap for the animation
        Bitmap animBitmap = SplashKit.LoadBitmap("animation_frames", "animation_frames.png");
        
        // Create an animation with 4 frames, 100ms per frame
        Animation anim = SplashKit.CreateAnimation("walking", animBitmap, 4, 100);
        
        // Create a sprite to display the animation
        Sprite animSprite = SplashKit.CreateSprite(animBitmap);
        SplashKit.SpriteStartAnimation(animSprite, anim);
        
        // Position the sprite in the center of the window
        SplashKit.SpriteSetX(animSprite, 350);
        SplashKit.SpriteSetY(animSprite, 250);
        
        while (!SplashKit.WindowCloseRequested("Animation Example"))
        {
            // Clear the screen
            SplashKit.ClearScreen();
            
            // Update the sprite animation
            SplashKit.UpdateSpriteAnimation(animSprite);
            
            // Draw the sprite
            SplashKit.DrawSprite(animSprite);
            
            // Refresh the screen
            SplashKit.RefreshScreen();
            
            // Process events
            SplashKit.ProcessEvents();
            
            // Small delay
            SplashKit.Delay(16);
        }
        
        // Clean up
        SplashKit.FreeAnimation(anim);
        SplashKit.FreeSprite(animSprite);
        SplashKit.FreeBitmap(animBitmap);
    }
} 