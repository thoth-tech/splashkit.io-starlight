using SplashKitSDK;

OpenWindow("Sprite Animation Creation", 800, 600);


AnimationScript walkScript = LoadAnimationScript("walk_cycle", "walk.txt");
Bitmap characterBmp = LoadBitmap("character", "character.png");
BitmapSetCellDetails(characterBmp, 64, 64, 4, 1, 4); // 4 frames in a row


Animation walkAnimation = CreateAnimation(walkScript, "walk");

Point2D characterPos = PointAt(100, 300);

while (!QuitRequested())
{
    ProcessEvents();
    

    characterPos.X += 2;
    if (characterPos.X > 800) characterPos.X = -64;
    
    // Update animation
    UpdateAnimation(walkAnimation);
    
    ClearScreen(Color.White);
    
    // Draw walking character
    DrawBitmap(characterBmp, characterPos.X, characterPos.Y, 
               OptionWithAnimation(walkAnimation));
    

    DrawText("Walking Character Animation", Color.Black, 10, 10);
    DrawText($"Animation Name: {AnimationName(walkAnimation)}", Color.Black, 10, 30);
    DrawText($"Current Frame: {AnimationCurrentCell(walkAnimation)}", 
             Color.Black, 10, 50);
    DrawText($"Animation Ended: {(AnimationEnded(walkAnimation) ? "Yes" : "No")}", 
             Color.Black, 10, 70);
    
    RefreshScreen(60);
}

FreeAnimation(walkAnimation);
FreeAnimationScript(walkScript);
FreeBitmap(characterBmp);
CloseAllWindows();
