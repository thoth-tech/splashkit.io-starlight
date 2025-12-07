using SplashKitSDK;

namespace RestartAnimationExample
{
    public class Program
    {
        public static void Main()
        {
            SplashKit.OpenWindow("Restart Animation Example", 800, 600);

            // Load animation script and create animation
            AnimationScript script = SplashKit.LoadAnimationScript("kermit", "kermit.txt");
            Animation anim = SplashKit.CreateAnimation(script, "SplashKitOnlineDemo");

            int restartCount = 0;

            while (!SplashKit.QuitRequested())
            {
                SplashKit.ProcessEvents();

                SplashKit.ClearScreen(Color.White);

                // Display animation state
                SplashKit.DrawText("Restart Animation Demo", Color.Black, 300, 100);
                SplashKit.DrawText($"Current Cell: {SplashKit.AnimationCurrentCell(anim)}", Color.Blue, 300, 200);
                SplashKit.DrawText($"Restart Count: {restartCount}", Color.Green, 300, 250);
                SplashKit.DrawText($"Animation Ended: {(SplashKit.AnimationEnded(anim) ? "Yes" : "No")}", Color.Purple, 300, 300);
                SplashKit.DrawText("Press SPACE to restart animation", Color.Orange, 250, 400);
                SplashKit.DrawText("Press ESC to exit", Color.Gray, 320, 500);

                // Restart animation when space is pressed
                if (SplashKit.KeyTyped(KeyCode.SpaceKey))
                {
                    SplashKit.RestartAnimation(anim);
                    restartCount++;
                }

                SplashKit.UpdateAnimation(anim);
                SplashKit.RefreshScreen(60);
            }

            // Free resources
            SplashKit.FreeAnimation(anim);
            SplashKit.FreeAnimationScript(script);

            SplashKit.CloseAllWindows();
        }
    }
}
