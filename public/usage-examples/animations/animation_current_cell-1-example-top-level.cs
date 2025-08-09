using SplashKitSDK;

OpenWindow("Current Frame Tracking", 800, 600);


AnimationScript statesScript = LoadAnimationScript("character_states", "states.txt");
Bitmap characterBmp = LoadBitmap("character", "character.png");
BitmapSetCellDetails(characterBmp, 64, 64, 8, 2, 16); 

// Create animation
Animation characterAnim = CreateAnimation(statesScript, "idle");

Point2D characterPos = PointAt(400, 300);
int prevCell = -1;

while (!QuitRequested())
{
    ProcessEvents();
    

    UpdateAnimation(characterAnim);

    int currentCell = AnimationCurrentCell(characterAnim);
    

    if (currentCell != prevCell)
    {
        WriteLine($"Frame changed from {prevCell} to {currentCell}");
        prevCell = currentCell;
    }
    
    ClearScreen(Color.LightBlue);

    DrawBitmap(characterBmp, characterPos.X - 32, characterPos.Y - 32,
               OptionWithAnimation(characterAnim));
    

    DrawText("Current Frame Tracking", Color.Black, 10, 10);
    DrawText($"Current Cell: {currentCell}", Color.Black, 10, 30);
    DrawText("Total Frames: 16", Color.Black, 10, 50);
    

    int barWidth = 400;
    int barX = 200;
    int barY = 100;
    
    DrawRectangle(Color.Gray, barX - 2, barY - 2, barWidth + 4, 24);
    DrawRectangle(Color.White, barX, barY, barWidth, 20);
    

    int framePos = (currentCell * barWidth) / 16;
    DrawRectangle(Color.Red, barX + framePos - 2, barY, 4, 20);
    

    for (int i = 0; i <= 16; i += 4)
    {
        int x = barX + (i * barWidth) / 16;
        DrawText(i.ToString(), Color.Black, x - 5, barY + 25);
    }
    
    RefreshScreen(60);
}

// Clean up
FreeAnimation(characterAnim);
FreeAnimationScript(statesScript);
FreeBitmap(characterBmp);
CloseAllWindows();
