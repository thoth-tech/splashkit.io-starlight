using SplashKitSDK;

OpenWindow("Dancing Frog Animation", 800, 600);

// Load the frog bitmap with animation cells
Bitmap frogBmp = LoadBitmap("frog", "frog.png");
BitmapSetCellDetails(frogBmp, 73, 105, 4, 4, 16); // 4x4 grid, 16 total frames

// Load animation script that defines the dancing sequence
AnimationScript danceScript = LoadAnimationScript("dance", "dance.txt");

// Create an animation from the script
Animation frogDance = CreateAnimation(danceScript, "dance");

Point2D frogPos = PointAt(400, 300);

while (!QuitRequested())
{
    ProcessEvents();
    
    // Update the animation
    UpdateAnimation(frogDance);
    
    ClearScreen(Color.LightGreen);
    
    // Draw the frog with current animation frame
    DrawBitmap(frogBmp, frogPos.X - 36, frogPos.Y - 52, 
               OptionWithAnimation(frogDance));
    
    // Show animation info
    DrawText("Press ESC to exit", Color.Black, 10, 10);
    DrawText($"Animation: {AnimationName(frogDance)}", Color.Black, 10, 30);
    DrawText($"Current Cell: {AnimationCurrentCell(frogDance)}", 
             Color.Black, 10, 50);
    
    RefreshScreen(60);
}

// Clean up
FreeAnimation(frogDance);
FreeAnimationScript(danceScript);
FreeBitmap(frogBmp);
CloseAllWindows();
