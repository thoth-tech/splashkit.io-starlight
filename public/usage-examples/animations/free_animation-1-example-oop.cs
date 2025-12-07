using SplashKitSDK;

namespace FreeAnimationExample
{
    public class Program
    {
        public static void Main()
        {
            SplashKit.OpenWindow("Free Animation Example", 800, 600);

            // Load animation script
            AnimationScript script = SplashKit.LoadAnimationScript("kermit", "kermit.txt");

            // Create animation
            Animation anim = SplashKit.CreateAnimation(script, "SplashKitOnlineDemo");
            bool animationExists = true;

            while (!SplashKit.QuitRequested())
            {
                SplashKit.ProcessEvents();

                SplashKit.ClearScreen(Color.White);

                // Display instructions
                SplashKit.DrawText("Free Animation Demo", Color.Black, 300, 100);

                if (animationExists)
                {
                    SplashKit.DrawText($"Current Cell: {SplashKit.AnimationCurrentCell(anim)}", Color.Blue, 300, 200);
                    SplashKit.DrawText("Animation Status: Active", Color.Green, 300, 250);
                    SplashKit.DrawText("Press F to FREE the animation", Color.Orange, 270, 400);

                    SplashKit.UpdateAnimation(anim);
                }
                else
                {
                    SplashKit.DrawText("Animation Status: Freed", Color.Red, 300, 250);
                    SplashKit.DrawText("Press C to CREATE new animation", Color.Orange, 260, 400);
                }

                SplashKit.DrawText("Press ESC to exit", Color.Gray, 320, 500);

                // Free animation when F is pressed
                if (SplashKit.KeyTyped(KeyCode.FKey) && animationExists)
                {
                    SplashKit.FreeAnimation(anim);
                    animationExists = false;
                }

                // Create new animation when C is pressed
                if (SplashKit.KeyTyped(KeyCode.CKey) && !animationExists)
                {
                    anim = SplashKit.CreateAnimation(script, "SplashKitOnlineDemo");
                    animationExists = true;
                }

                SplashKit.RefreshScreen(60);
            }

            // Final cleanup
            if (animationExists)
            {
                SplashKit.FreeAnimation(anim);
            }
            SplashKit.FreeAnimationScript(script);

            SplashKit.CloseAllWindows();
        }
    }
}
