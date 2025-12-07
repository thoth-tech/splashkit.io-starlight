using SplashKitSDK;

namespace AnimationEndedExample
{
    public class Program
    {
        public static void Main()
        {
            SplashKit.OpenWindow("Animation Ended Example", 800, 600);

            // Load animation script and create animation
            AnimationScript script = SplashKit.LoadAnimationScript("kermit", "kermit.txt");
            Animation anim = SplashKit.CreateAnimation(script, "SplashKitOnlineDemo");

            while (!SplashKit.QuitRequested())
            {
                SplashKit.ProcessEvents();

                SplashKit.ClearScreen(Color.White);

                // Display animation state
                SplashKit.DrawText("Animation Ended Example", Color.Black, 280, 100);
                SplashKit.DrawText($"Current Cell: {SplashKit.AnimationCurrentCell(anim)}", Color.Blue, 300, 200);

                // Check if animation has ended using animation_ended
                if (SplashKit.AnimationEnded(anim))
                {
                    SplashKit.DrawText("Animation Status: ENDED", Color.Red, 300, 250);
                    SplashKit.DrawText("Press R to restart", Color.Orange, 310, 350);

                    if (SplashKit.KeyTyped(KeyCode.RKey))
                    {
                        SplashKit.RestartAnimation(anim);
                    }
                }
                else
                {
                    SplashKit.DrawText("Animation Status: RUNNING", Color.Green, 300, 250);
                    SplashKit.UpdateAnimation(anim);
                }

                SplashKit.DrawText("Press ESC to exit", Color.Gray, 320, 500);

                SplashKit.RefreshScreen(60);
            }

            // Free resources
            SplashKit.FreeAnimation(anim);
            SplashKit.FreeAnimationScript(script);

            SplashKit.CloseAllWindows();
        }
    }
}
