using SplashKitSDK;

namespace AnimationFrameTimeExample
{
    public class Program
    {
        public static void Main()
        {
            SplashKit.OpenWindow("Animation Frame Time Example", 800, 600);

            // Load animation script and create animation
            AnimationScript script = SplashKit.LoadAnimationScript("explosion", "explosion.txt");
            Animation anim = SplashKit.CreateAnimation(script, "Explosion");

            while (!SplashKit.QuitRequested())
            {
                SplashKit.ProcessEvents();

                SplashKit.ClearScreen(Color.White);

                // Display animation frame time
                SplashKit.DrawText("Animation Frame Time Example", Color.Black, 270, 100);
                SplashKit.DrawText($"Current Cell: {SplashKit.AnimationCurrentCell(anim)}", Color.Blue, 300, 200);

                // Get and display frame time using animation_frame_time
                float frameTime = SplashKit.AnimationFrameTime(anim);
                SplashKit.DrawText($"Frame Time: {frameTime} ms", Color.Green, 300, 250);

                // Display instructions
                SplashKit.DrawText("Frame time shows how long this frame lasts", Color.Purple, 230, 350);
                SplashKit.DrawText("Press R to restart animation", Color.Orange, 280, 450);
                SplashKit.DrawText("Press ESC to exit", Color.Gray, 320, 500);

                if (SplashKit.KeyTyped(KeyCode.RKey))
                {
                    SplashKit.RestartAnimation(anim);
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
