using SplashKitSDK;

namespace UpdateAnimationExample
{
    public class Program
    {
        public static void Main()
        {
            SplashKit.OpenWindow("Update Animation Example", 800, 600);

            // Load animation script and create animation
            AnimationScript script = SplashKit.LoadAnimationScript("kermit", "kermit.txt");
            Animation anim = SplashKit.CreateAnimation(script, "SplashKitOnlineDemo");

            // Animation loop
            while (!SplashKit.QuitRequested() && !SplashKit.AnimationEnded(anim))
            {
                SplashKit.ProcessEvents();

                SplashKit.ClearScreen(Color.White);

                // Display current animation state
                SplashKit.DrawText("Update Animation Demo", Color.Black, 300, 100);
                SplashKit.DrawText($"Current Cell: {SplashKit.AnimationCurrentCell(anim)}", Color.Blue, 300, 200);
                SplashKit.DrawText($"Frame Time: {SplashKit.AnimationFrameTime(anim)}", Color.Green, 300, 250);
                SplashKit.DrawText($"Animation Ended: {(SplashKit.AnimationEnded(anim) ? "Yes" : "No")}", Color.Purple, 300, 300);
                SplashKit.DrawText("Press ESC to exit", Color.Gray, 320, 500);

                // Update the animation
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
