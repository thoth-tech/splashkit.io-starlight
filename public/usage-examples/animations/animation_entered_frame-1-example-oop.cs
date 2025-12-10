using SplashKitSDK;

namespace AnimationEnteredFrameExample
{
    public class Program
    {
        public static void Main()
        {
            SplashKit.OpenWindow("Animation Entered Frame Example", 800, 600);

            // Load animation script and create animation
            AnimationScript script = SplashKit.LoadAnimationScript("explosion", "explosion.txt");
            Animation anim = SplashKit.CreateAnimation(script, "Explosion");

            int frameEnterCount = 0;  

            while (!SplashKit.QuitRequested())
            {
                SplashKit.ProcessEvents();

                SplashKit.ClearScreen(Color.White);

                // Display animation state
                SplashKit.DrawText("Animation Entered Frame Example", Color.Black, 260, 100);
                SplashKit.DrawText($"Current Cell: {SplashKit.AnimationCurrentCell(anim)}", Color.Blue, 300, 200);

                // Check if animation entered a new frame using animation_entered_frame
                if (SplashKit.AnimationEnteredFrame(anim))
                {
                    frameEnterCount++;
                    SplashKit.DrawText("Just entered NEW FRAME!", Color.Green, 290, 280);
                }
                else
                {
                    SplashKit.DrawText("Same frame as before", Color.Gray, 310, 280);
                }

                SplashKit.DrawText($"Frame Entry Count: {frameEnterCount}", Color.Purple, 300, 340);

                // Display instructions
                SplashKit.DrawText("Press R to restart animation", Color.Orange, 280, 450);
                SplashKit.DrawText("Press ESC to exit", Color.Gray, 320, 500);

                if (SplashKit.KeyTyped(KeyCode.RKey))
                {
                    SplashKit.RestartAnimation(anim);
                    frameEnterCount = 0;
                }

                // Only update if animation hasn't ended
                if (!SplashKit.AnimationEnded(anim))
                {
                    SplashKit.UpdateAnimation(anim);
                }

                SplashKit.RefreshScreen(60);
            }

            // Free resources
            SplashKit.FreeAnimation(anim);
            SplashKit.FreeAnimationScript(script);

            SplashKit.CloseAllWindows();
        }
    }
}
