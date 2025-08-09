using SplashKitSDK;

Program.Main();

public static class Program
{
    public static void Main()
    {
        SplashKit.OpenWindow("Sprite Animation Creation", 800, 600);
        

        AnimationScript walkScript = SplashKit.LoadAnimationScript("walk_cycle", "walk.txt");
        Bitmap characterBmp = SplashKit.LoadBitmap("character", "character.png");
        SplashKit.BitmapSetCellDetails(characterBmp, 64, 64, 4, 1, 4); // 4 frames in a row
        

        Animation walkAnimation = SplashKit.CreateAnimation(walkScript, "walk");
        
        Point2D characterPos = SplashKit.PointAt(100, 300);
        
        while (!SplashKit.QuitRequested())
        {
            SplashKit.ProcessEvents();
            

            characterPos.X += 2;
            if (characterPos.X > 800) characterPos.X = -64;
            

            SplashKit.UpdateAnimation(walkAnimation);
            
            SplashKit.ClearScreen(Color.White);
            

            SplashKit.DrawBitmap(characterBmp, characterPos.X, characterPos.Y, 
                               SplashKit.OptionWithAnimation(walkAnimation));
            

            SplashKit.DrawText("Walking Character Animation", Color.Black, 10, 10);
            SplashKit.DrawText($"Animation Name: {SplashKit.AnimationName(walkAnimation)}", Color.Black, 10, 30);
            SplashKit.DrawText($"Current Frame: {SplashKit.AnimationCurrentCell(walkAnimation)}", 
                             Color.Black, 10, 50);
            SplashKit.DrawText($"Animation Ended: {(SplashKit.AnimationEnded(walkAnimation) ? "Yes" : "No")}", 
                             Color.Black, 10, 70);
            
            SplashKit.RefreshScreen(60);
        }
        

        SplashKit.FreeAnimation(walkAnimation);
        SplashKit.FreeAnimationScript(walkScript);
        SplashKit.FreeBitmap(characterBmp);
        SplashKit.CloseAllWindows();
    }
}
