using SplashKitSDK;

public class Program
{
    public static void Main()
    {
        SplashKit.OpenWindow("Animation Restart Demo", 800, 600);
        
        // Load animation script and bitmap
        AnimationScript danceScript = SplashKit.LoadAnimationScript("dancer", "dancer.txt");
        Bitmap dancerBmp = SplashKit.LoadBitmap("dancer", "dancer.png");
        SplashKit.BitmapSetCellDetails(dancerBmp, 80, 80, 3, 3, 9); // 3x3 grid, 9 frames
        
        // Create animation
        Animation danceAnim = SplashKit.CreateAnimation(danceScript, "dance_sequence");
        
        Point2D dancerPos = SplashKit.PointAt(400, 300);
        bool isPlaying = true;
        bool showRestartMessage = false;
        Timer restartTimer = SplashKit.CreateTimer("restart_timer");
        
        while (!SplashKit.QuitRequested())
        {
            SplashKit.ProcessEvents();
            
            // Toggle animation playback with spacebar
            if (SplashKit.KeyTyped(KeyCode.SpaceKey))
            {
                if (isPlaying)
                {
                    // Stop the animation (it will pause at current frame)
                    isPlaying = false;
                }
                else
                {
                    // Restart animation from beginning
                    SplashKit.RestartAnimation(danceAnim);
                    isPlaying = true;
                    showRestartMessage = true;
                    SplashKit.StartTimer(restartTimer);
                }
            }
            
            // Auto-restart when animation ends
            if (isPlaying && SplashKit.AnimationEnded(danceAnim))
            {
                SplashKit.RestartAnimation(danceAnim);
                showRestartMessage = true;
                SplashKit.StartTimer(restartTimer);
            }
            
            // Update animation only when playing
            if (isPlaying)
            {
                SplashKit.UpdateAnimation(danceAnim);
            }
            
            // Hide restart message after 1 second
            if (showRestartMessage && SplashKit.TimerTicks(restartTimer) > 1000)
            {
                showRestartMessage = false;
            }
            
            SplashKit.ClearScreen(SplashKit.ColorLightBlue());
            
            // Draw dancer
            SplashKit.DrawBitmap(dancerBmp, dancerPos.X - 40, dancerPos.Y - 40,
                               SplashKit.OptionWithAnimation(danceAnim));
            
            // Draw UI
            SplashKit.DrawText("Animation Restart Demo", SplashKit.ColorBlack(), 10, 10);
            SplashKit.DrawText("Press SPACE to stop/restart animation", SplashKit.ColorBlack(), 10, 30);
            SplashKit.DrawText("Animation auto-restarts when it ends", SplashKit.ColorBlack(), 10, 50);
            
            // Show current animation state
            string status = isPlaying ? "PLAYING" : "STOPPED";
            Color statusColor = isPlaying ? SplashKit.ColorGreen() : SplashKit.ColorRed();
            SplashKit.DrawText($"Status: {status}", statusColor, 10, 80);
            SplashKit.DrawText($"Frame: {SplashKit.AnimationCurrentCell(danceAnim)}", SplashKit.ColorBlue(), 10, 100);
            SplashKit.DrawText($"Ended: {(SplashKit.AnimationEnded(danceAnim) ? "Yes" : "No")}", 
                             SplashKit.ColorPurple(), 10, 120);
            
            // Show restart message
            if (showRestartMessage)
            {
                SplashKit.DrawText("*** ANIMATION RESTARTED ***", SplashKit.ColorRed(), 10, 150);
            }
            
            // Draw animation progress bar
            int progressWidth = 300;
            int progressHeight = 20;
            int progressX = 10;
            int progressY = 180;
            
            SplashKit.DrawRectangle(SplashKit.ColorWhite(), progressX, progressY, progressWidth, progressHeight);
            SplashKit.DrawRectangle(SplashKit.ColorBlack(), progressX, progressY, progressWidth, progressHeight, 
                                  SplashKit.OptionLineWidth(2));
            
            // Calculate progress based on current frame
            if (SplashKit.AnimationCurrentCell(danceAnim) >= 0)
            {
                float progress = (float)SplashKit.AnimationCurrentCell(danceAnim) / 8.0f; // 0-8 frames
                int fillWidth = (int)(progress * (progressWidth - 4));
                SplashKit.DrawRectangle(SplashKit.ColorOrange(), progressX + 2, progressY + 2, 
                                      fillWidth, progressHeight - 4);
            }
            
            SplashKit.DrawText("Animation Progress", SplashKit.ColorBlack(), progressX, progressY - 20);
            
            SplashKit.RefreshScreen(60);
        }
        
        // Clean up
        SplashKit.FreeAnimation(danceAnim);
        SplashKit.FreeAnimationScript(danceScript);
        SplashKit.FreeBitmap(dancerBmp);
        SplashKit.FreeTimer(restartTimer);
        SplashKit.CloseAllWindows();
    }
}
