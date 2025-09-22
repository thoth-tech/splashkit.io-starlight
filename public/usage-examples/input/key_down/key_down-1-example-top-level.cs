using static SplashKitSDK.SplashKit;

OpenWindow("Key Down Demo", 800, 600);

double x = 400, y = 300;
double speed = 5.0;

while (!WindowCloseRequested("Key Down Demo"))
{
    ProcessEvents();
    
    // Move the circle based on arrow keys being held down
    if (KeyDown(KeyCode.UpKey))
        y -= speed;
    if (KeyDown(KeyCode.DownKey))
        y += speed;
    if (KeyDown(KeyCode.LeftKey))
        x -= speed;
    if (KeyDown(KeyCode.RightKey))
        x += speed;
    
    // Keep the circle within window bounds
    if (x < 25) x = 25;
    if (x > 775) x = 775;
    if (y < 25) y = 25;
    if (y > 575) y = 575;
    
    ClearScreen(Color.Black);
    
    // Draw the controllable circle
    FillCircle(Color.Blue, x, y, 25);
    
    // Show instructions and key states
    DrawText("Use arrow keys to move the circle", Color.White, 10, 10);
    DrawText("Hold keys for continuous movement", Color.White, 10, 30);
    
    // Show which keys are currently pressed
    string status = "Keys pressed: ";
    if (KeyDown(KeyCode.UpKey)) status += "UP ";
    if (KeyDown(KeyCode.DownKey)) status += "DOWN ";
    if (KeyDown(KeyCode.LeftKey)) status += "LEFT ";
    if (KeyDown(KeyCode.RightKey)) status += "RIGHT ";
    if (!KeyDown(KeyCode.UpKey) && !KeyDown(KeyCode.DownKey) && 
        !KeyDown(KeyCode.LeftKey) && !KeyDown(KeyCode.RightKey))
        status += "None";
        
    DrawText(status, Color.Yellow, 10, 50);
    
    // Show position
    DrawText($"Position: ({(int)x}, {(int)y})", Color.Green, 10, 70);
    
    RefreshScreen(60);
}

CloseWindow("Key Down Demo");