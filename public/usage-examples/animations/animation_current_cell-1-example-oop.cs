using SplashKitSDK;

Program.Main();

public static class Program
{
    public static void Main()
    {
        SplashKit.OpenWindow("Current Frame Tracking", 800, 600);
        
        // Load animation script and bitmap for character states
        AnimationScript statesScript = SplashKit.LoadAnimationScript("character_states", "states.txt");
        Bitmap characterBmp = SplashKit.LoadBitmap("character", "character.png");
        SplashKit.BitmapSetCellDetails(characterBmp, 64, 64, 8, 2, 16); // 8x2 grid, 16 frames
        
        // Create animation
        Animation characterAnim = SplashKit.CreateAnimation(statesScript, "idle");
        
        Point2D characterPos = SplashKit.PointAt(400, 300);
        int prevCell = -1;
        
        while (!SplashKit.QuitRequested())
        {
            SplashKit.ProcessEvents();
            
            // Update animation
            SplashKit.UpdateAnimation(characterAnim);
            
            // Get current animation cell
            int currentCell = SplashKit.AnimationCurrentCell(characterAnim);
            
            // Detect frame changes
            if (currentCell != prevCell)
            {
                SplashKit.WriteLine($"Frame changed from {prevCell} to {currentCell}");
                prevCell = currentCell;
            }
            
            SplashKit.ClearScreen(Color.LightBlue);
            
            // Draw character
            SplashKit.DrawBitmap(characterBmp, characterPos.X - 32, characterPos.Y - 32,
                               SplashKit.OptionWithAnimation(characterAnim));
            
            // Draw frame information
            SplashKit.DrawText("Current Frame Tracking", Color.Black, 10, 10);
            SplashKit.DrawText($"Current Cell: {currentCell}", Color.Black, 10, 30);
            SplashKit.DrawText("Total Frames: 16", Color.Black, 10, 50);
            
            // Draw frame indicator bar
            int barWidth = 400;
            int barX = 200;
            int barY = 100;
            
            SplashKit.DrawRectangle(Color.Gray, barX - 2, barY - 2, barWidth + 4, 24);
            SplashKit.DrawRectangle(Color.White, barX, barY, barWidth, 20);
            
            // Draw current frame position
            int framePos = (currentCell * barWidth) / 16;
            SplashKit.DrawRectangle(Color.Red, barX + framePos - 2, barY, 4, 20);
            
            // Draw frame numbers
            for (int i = 0; i <= 16; i += 4)
            {
                int x = barX + (i * barWidth) / 16;
                SplashKit.DrawText(i.ToString(), Color.Black, x - 5, barY + 25);
            }
            
            SplashKit.RefreshScreen(60);
        }
        
        // Clean up
        SplashKit.FreeAnimation(characterAnim);
        SplashKit.FreeAnimationScript(statesScript);
        SplashKit.FreeBitmap(characterBmp);
        SplashKit.CloseAllWindows();
    }
}
