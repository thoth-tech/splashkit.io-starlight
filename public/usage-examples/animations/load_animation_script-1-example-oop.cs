using SplashKitSDK;

Program.Main();

public static class Program
{
    public static void Main()
    {
        SplashKit.OpenWindow("Dancing Frog Animation", 800, 600);
        
        // Load the frog bitmap with animation cells
        Bitmap frogBmp = SplashKit.LoadBitmap("frog", "frog.png");
        SplashKit.BitmapSetCellDetails(frogBmp, 73, 105, 4, 4, 16); // 4x4 grid, 16 total frames
        
        // Load animation script that defines the dancing sequence
        AnimationScript danceScript = SplashKit.LoadAnimationScript("dance", "dance.txt");
        
        // Create an animation from the script
        Animation frogDance = SplashKit.CreateAnimation(danceScript, "dance");
        
        Point2D frogPos = SplashKit.PointAt(400, 300);
        
        while (!SplashKit.QuitRequested())
        {
            SplashKit.ProcessEvents();
            
            // Update the animation
            SplashKit.UpdateAnimation(frogDance);
            
            SplashKit.ClearScreen(Color.LightGreen);
            
            // Draw the frog with current animation frame
            SplashKit.DrawBitmap(frogBmp, frogPos.X - 36, frogPos.Y - 52, 
                               SplashKit.OptionWithAnimation(frogDance));
            
            // Show animation info
            SplashKit.DrawText("Press ESC to exit", Color.Black, 10, 10);
            SplashKit.DrawText($"Animation: {SplashKit.AnimationName(frogDance)}", Color.Black, 10, 30);
            SplashKit.DrawText($"Current Cell: {SplashKit.AnimationCurrentCell(frogDance)}", 
                             Color.Black, 10, 50);
            
            SplashKit.RefreshScreen(60);
        }
        
        // Clean up
        SplashKit.FreeAnimation(frogDance);
        SplashKit.FreeAnimationScript(danceScript);
        SplashKit.FreeBitmap(frogBmp);
        SplashKit.CloseAllWindows();
    }
}
