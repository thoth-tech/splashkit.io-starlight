using static SplashKitSDK.SplashKit;

OpenWindow("Animation State Switching", 800, 600);

// Load animation script and bitmap for player character
var playerScript = LoadAnimationScript("player_states", "player.txt");
var playerBmp = LoadBitmap("player", "player.png");
BitmapSetCellDetails(playerBmp, 64, 64, 4, 4, 16); // 4x4 grid, 16 frames

// Create animation starting with idle state
var playerAnim = CreateAnimation(playerScript, "idle");

var playerPos = PointAt(400, 300);
string currentState = "idle";

while (!QuitRequested())
{
    ProcessEvents();
    
    // Switch animations based on keyboard input
    if (KeyTyped(KeyCode.Num1Key))
    {
        AssignAnimation(playerAnim, "idle");
        currentState = "idle";
    }
    else if (KeyTyped(KeyCode.Num2Key))
    {
        AssignAnimation(playerAnim, "walk");
        currentState = "walk";
    }
    else if (KeyTyped(KeyCode.Num3Key))
    {
        AssignAnimation(playerAnim, "run");
        currentState = "run";
    }
    else if (KeyTyped(KeyCode.Num4Key))
    {
        AssignAnimation(playerAnim, "jump");
        currentState = "jump";
    }
    
    // Update animation
    UpdateAnimation(playerAnim);
    
    ClearScreen(ColorLightGray());
    
    // Draw player character
    DrawBitmap(playerBmp, playerPos.X - 32, playerPos.Y - 32,
               OptionWithAnimation(playerAnim));
    
    // Draw instructions and current state
    DrawText("Animation State Switching", ColorBlack(), 10, 10);
    DrawText("Press 1-4 to change animation:", ColorBlack(), 10, 30);
    DrawText("1: Idle  2: Walk  3: Run  4: Jump", ColorBlack(), 10, 50);
    DrawText($"Current State: {currentState}", ColorRed(), 10, 80);
    DrawText($"Animation: {AnimationName(playerAnim)}", ColorBlue(), 10, 100);
    DrawText($"Frame: {AnimationCurrentCell(playerAnim)}", ColorBlue(), 10, 120);
    
    // Draw state indicator
    int indicatorX = 10;
    int indicatorY = 150;
    
    if (currentState == "idle") DrawRectangle(ColorGreen(), indicatorX, indicatorY, 50, 20);
    else DrawRectangle(ColorGray(), indicatorX, indicatorY, 50, 20);
    DrawText("IDLE", ColorWhite(), indicatorX + 10, indicatorY + 5);
    
    indicatorX += 60;
    if (currentState == "walk") DrawRectangle(ColorGreen(), indicatorX, indicatorY, 50, 20);
    else DrawRectangle(ColorGray(), indicatorX, indicatorY, 50, 20);
    DrawText("WALK", ColorWhite(), indicatorX + 10, indicatorY + 5);
    
    indicatorX += 60;
    if (currentState == "run") DrawRectangle(ColorGreen(), indicatorX, indicatorY, 50, 20);
    else DrawRectangle(ColorGray(), indicatorX, indicatorY, 50, 20);
    DrawText("RUN", ColorWhite(), indicatorX + 15, indicatorY + 5);
    
    indicatorX += 60;
    if (currentState == "jump") DrawRectangle(ColorGreen(), indicatorX, indicatorY, 50, 20);
    else DrawRectangle(ColorGray(), indicatorX, indicatorY, 50, 20);
    DrawText("JUMP", ColorWhite(), indicatorX + 10, indicatorY + 5);
    
    RefreshScreen(60);
}

// Clean up
FreeAnimation(playerAnim);
FreeAnimationScript(playerScript);
FreeBitmap(playerBmp);
CloseAllWindows();
