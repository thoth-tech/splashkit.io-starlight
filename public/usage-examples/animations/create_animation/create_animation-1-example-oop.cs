using System;
using static SplashKitSDK.SplashKit;

public class Program
{
    public static void Main()
    {
        OpenWindow("Create Animation Demo", 400, 300);
        
        // Load bitmap and set cell details
        Bitmap walkBitmap = LoadBitmap("walk", "walk.png");
        BitmapSetCellDetails(walkBitmap, 73, 105, 4, 4, 16);
        
        // Load animation script
        AnimationScript walkScript = LoadAnimationScript("walk", "walk.txt");
        
        // Create animation from script using the "walk" animation name
        Animation walkAnim = CreateAnimation(walkScript, "walk");
        
        // Main loop
        while (!QuitRequested())
        {
            ProcessEvents();
            ClearScreen(Color.White);
            
            // Draw animated bitmap
            DrawBitmap(walkBitmap, 150, 100, OptionWithAnimation(walkAnim));
            UpdateAnimation(walkAnim);
            
            RefreshScreen(60);
        }
        
        CloseAllWindows();
    }
}
