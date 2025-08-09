using SplashKitSDK;

public class Program
{
    public static void Main()
    {
        SplashKit.OpenWindow("Animation State Switching", 800, 600);
        
        // Load animation script and bitmap for player character
        AnimationScript playerScript = SplashKit.LoadAnimationScript("player_states", "player.txt");
        Bitmap playerBmp = SplashKit.LoadBitmap("player", "player.png");
        SplashKit.BitmapSetCellDetails(playerBmp, 64, 64, 4, 4, 16); // 4x4 grid, 16 frames
        
        // Create animation starting with idle state
        Animation playerAnim = SplashKit.CreateAnimation(playerScript, "idle");
        
        Point2D playerPos = SplashKit.PointAt(400, 300);
        string currentState = "idle";
        
        while (!SplashKit.QuitRequested())
        {
            SplashKit.ProcessEvents();
            
            // Switch animations based on keyboard input
            if (SplashKit.KeyTyped(KeyCode.Num1Key))
            {
                SplashKit.AssignAnimation(playerAnim, "idle");
                currentState = "idle";
            }
            else if (SplashKit.KeyTyped(KeyCode.Num2Key))
            {
                SplashKit.AssignAnimation(playerAnim, "walk");
                currentState = "walk";
            }
            else if (SplashKit.KeyTyped(KeyCode.Num3Key))
            {
                SplashKit.AssignAnimation(playerAnim, "run");
                currentState = "run";
            }
            else if (SplashKit.KeyTyped(KeyCode.Num4Key))
            {
                SplashKit.AssignAnimation(playerAnim, "jump");
                currentState = "jump";
            }
            
            // Update animation
            SplashKit.UpdateAnimation(playerAnim);
            
            SplashKit.ClearScreen(SplashKit.ColorLightGray());
            
            // Draw player character
            SplashKit.DrawBitmap(playerBmp, playerPos.X - 32, playerPos.Y - 32,
                               SplashKit.OptionWithAnimation(playerAnim));
            
            // Draw instructions and current state
            SplashKit.DrawText("Animation State Switching", SplashKit.ColorBlack(), 10, 10);
            SplashKit.DrawText("Press 1-4 to change animation:", SplashKit.ColorBlack(), 10, 30);
            SplashKit.DrawText("1: Idle  2: Walk  3: Run  4: Jump", SplashKit.ColorBlack(), 10, 50);
            SplashKit.DrawText($"Current State: {currentState}", SplashKit.ColorRed(), 10, 80);
            SplashKit.DrawText($"Animation: {SplashKit.AnimationName(playerAnim)}", SplashKit.ColorBlue(), 10, 100);
            SplashKit.DrawText($"Frame: {SplashKit.AnimationCurrentCell(playerAnim)}", 
                             SplashKit.ColorBlue(), 10, 120);
            
            // Draw state indicator
            int indicatorX = 10;
            int indicatorY = 150;
            
            if (currentState == "idle") SplashKit.DrawRectangle(SplashKit.ColorGreen(), indicatorX, indicatorY, 50, 20);
            else SplashKit.DrawRectangle(SplashKit.ColorGray(), indicatorX, indicatorY, 50, 20);
            SplashKit.DrawText("IDLE", SplashKit.ColorWhite(), indicatorX + 10, indicatorY + 5);
            
            indicatorX += 60;
            if (currentState == "walk") SplashKit.DrawRectangle(SplashKit.ColorGreen(), indicatorX, indicatorY, 50, 20);
            else SplashKit.DrawRectangle(SplashKit.ColorGray(), indicatorX, indicatorY, 50, 20);
            SplashKit.DrawText("WALK", SplashKit.ColorWhite(), indicatorX + 10, indicatorY + 5);
            
            indicatorX += 60;
            if (currentState == "run") SplashKit.DrawRectangle(SplashKit.ColorGreen(), indicatorX, indicatorY, 50, 20);
            else SplashKit.DrawRectangle(SplashKit.ColorGray(), indicatorX, indicatorY, 50, 20);
            SplashKit.DrawText("RUN", SplashKit.ColorWhite(), indicatorX + 15, indicatorY + 5);
            
            indicatorX += 60;
            if (currentState == "jump") SplashKit.DrawRectangle(SplashKit.ColorGreen(), indicatorX, indicatorY, 50, 20);
            else SplashKit.DrawRectangle(SplashKit.ColorGray(), indicatorX, indicatorY, 50, 20);
            SplashKit.DrawText("JUMP", SplashKit.ColorWhite(), indicatorX + 10, indicatorY + 5);
            
            SplashKit.RefreshScreen(60);
        }
        
        // Clean up
        SplashKit.FreeAnimation(playerAnim);
        SplashKit.FreeAnimationScript(playerScript);
        SplashKit.FreeBitmap(playerBmp);
        SplashKit.CloseAllWindows();
    }
}
