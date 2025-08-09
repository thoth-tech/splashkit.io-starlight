using static SplashKitSDK.SplashKit;

OpenWindow("Animation Restart Demo", 800, 600);

// Load animation script and bitmap
var danceScript = LoadAnimationScript("dancer", "dancer.txt");
var dancerBmp = LoadBitmap("dancer", "dancer.png");
BitmapSetCellDetails(dancerBmp, 80, 80, 3, 3, 9); // 3x3 grid, 9 frames

// Create animation
var danceAnim = CreateAnimation(danceScript, "dance_sequence");

var dancerPos = PointAt(400, 300);
bool isPlaying = true;
bool showRestartMessage = false;
var restartTimer = CreateTimer("restart_timer");

while (!QuitRequested())
{
    ProcessEvents();
    
    // Toggle animation playback with spacebar
    if (KeyTyped(KeyCode.SpaceKey))
    {
        if (isPlaying)
        {
            // Stop the animation (it will pause at current frame)
            isPlaying = false;
        }
        else
        {
            // Restart animation from beginning
            RestartAnimation(danceAnim);
            isPlaying = true;
            showRestartMessage = true;
            StartTimer(restartTimer);
        }
    }
    
    // Auto-restart when animation ends
    if (isPlaying && AnimationEnded(danceAnim))
    {
        RestartAnimation(danceAnim);
        showRestartMessage = true;
        StartTimer(restartTimer);
    }
    
    // Update animation only when playing
    if (isPlaying)
    {
        UpdateAnimation(danceAnim);
    }
    
    // Hide restart message after 1 second
    if (showRestartMessage && TimerTicks(restartTimer) > 1000)
    {
        showRestartMessage = false;
    }
    
    ClearScreen(ColorLightBlue());
    
    // Draw dancer
    DrawBitmap(dancerBmp, dancerPos.X - 40, dancerPos.Y - 40,
               OptionWithAnimation(danceAnim));
    
    // Draw UI
    DrawText("Animation Restart Demo", ColorBlack(), 10, 10);
    DrawText("Press SPACE to stop/restart animation", ColorBlack(), 10, 30);
    DrawText("Animation auto-restarts when it ends", ColorBlack(), 10, 50);
    
    // Show current animation state
    string status = isPlaying ? "PLAYING" : "STOPPED";
    var statusColor = isPlaying ? ColorGreen() : ColorRed();
    DrawText($"Status: {status}", statusColor, 10, 80);
    DrawText($"Frame: {AnimationCurrentCell(danceAnim)}", ColorBlue(), 10, 100);
    DrawText($"Ended: {(AnimationEnded(danceAnim) ? "Yes" : "No")}", ColorPurple(), 10, 120);
    
    // Show restart message
    if (showRestartMessage)
    {
        DrawText("*** ANIMATION RESTARTED ***", ColorRed(), 10, 150);
    }
    
    // Draw animation progress bar
    int progressWidth = 300;
    int progressHeight = 20;
    int progressX = 10;
    int progressY = 180;
    
    DrawRectangle(ColorWhite(), progressX, progressY, progressWidth, progressHeight);
    DrawRectangle(ColorBlack(), progressX, progressY, progressWidth, progressHeight, 
                  OptionLineWidth(2));
    
    // Calculate progress based on current frame
    if (AnimationCurrentCell(danceAnim) >= 0)
    {
        float progress = (float)AnimationCurrentCell(danceAnim) / 8.0f; // 0-8 frames
        int fillWidth = (int)(progress * (progressWidth - 4));
        DrawRectangle(ColorOrange(), progressX + 2, progressY + 2, 
                      fillWidth, progressHeight - 4);
    }
    
    DrawText("Animation Progress", ColorBlack(), progressX, progressY - 20);
    
    RefreshScreen(60);
}

// Clean up
FreeAnimation(danceAnim);
FreeAnimationScript(danceScript);
FreeBitmap(dancerBmp);
FreeTimer(restartTimer);
CloseAllWindows();
