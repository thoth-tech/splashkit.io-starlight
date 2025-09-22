using SplashKitSDK;

// Open a window
SplashKit.OpenWindow("Camera Movement Example", 800, 600);

// Load a bitmap for the background
Bitmap background = SplashKit.LoadBitmap("background", "background.png");

// Create a sprite to follow with the camera
Sprite player = SplashKit.CreateSprite(background);
SplashKit.SpriteSetX(player, 100);
SplashKit.SpriteSetY(player, 100);

// Set initial camera position
SplashKit.SetCameraPosition(SplashKit.VectorTo(0, 0));

SplashKit.WriteLine("Camera Movement Example");
SplashKit.WriteLine("Press SPACE to move camera to player position");
SplashKit.WriteLine("Press ESC to exit");

while (!SplashKit.WindowCloseRequested("Camera Movement Example"))
{
    // Clear the screen
    SplashKit.ClearScreen();
    
    // Draw the background
    SplashKit.DrawBitmap(background, 0, 0);
    
    // Draw the player sprite
    SplashKit.DrawSprite(player);
    
    // Handle input
    if (SplashKit.KeyTyped(KeyCode.SpaceKey))
    {
        // Move camera to center on the player
        Point2D playerPos = SplashKit.SpritePosition(player);
        SplashKit.MoveCameraTo(playerPos);
        SplashKit.WriteLine("Camera moved to player position!");
    }
    
    // Display camera position
    Point2D camPos = SplashKit.CameraPosition();
    SplashKit.DrawText("Camera X: " + camPos.X + " Y: " + camPos.Y, Color.White, 10, 10);
    
    // Refresh the screen
    SplashKit.RefreshScreen();
    
    // Process events
    SplashKit.ProcessEvents();
    
    // Small delay
    SplashKit.Delay(16);
}

// Clean up
SplashKit.FreeSprite(player);
SplashKit.FreeBitmap(background); 