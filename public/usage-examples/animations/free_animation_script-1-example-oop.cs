using SplashKitSDK;

namespace FreeAnimationScriptExample
{
    public class Program
    {
        public static void Main()
        {
            SplashKit.OpenWindow("Free Animation Script Example", 800, 600);

            // Load animation script
            AnimationScript script = SplashKit.LoadAnimationScript("kermit", "kermit.txt");
            bool scriptLoaded = true;

            Animation anim = SplashKit.CreateAnimation(script, "SplashKitOnlineDemo");
            bool animationExists = true;

            while (!SplashKit.QuitRequested())
            {
                SplashKit.ProcessEvents();

                SplashKit.ClearScreen(Color.White);

                // Display instructions
                SplashKit.DrawText("Free Animation Script Demo", Color.Black, 280, 100);

                if (scriptLoaded)
                {
                    SplashKit.DrawText("Script Status: LOADED", Color.Green, 300, 200);

                    if (animationExists)
                    {
                        SplashKit.DrawText($"Animation Cell: {SplashKit.AnimationCurrentCell(anim)}", Color.Blue, 300, 250);
                        SplashKit.UpdateAnimation(anim);
                    }

                    SplashKit.DrawText("Press F to free animation script", Color.Orange, 260, 400);
                    SplashKit.DrawText("(Will also free the animation)", Color.Gray, 280, 430);

                    if (SplashKit.KeyTyped(KeyCode.FKey))
                    {
                        // First free the animation that uses this script
                        if (animationExists)
                        {
                            SplashKit.FreeAnimation(anim);
                            animationExists = false;
                        }
                        // Then free the animation script
                        SplashKit.FreeAnimationScript(script);
                        scriptLoaded = false;
                    }
                }
                else
                {
                    SplashKit.DrawText("Script Status: FREED", Color.Red, 300, 200);
                    SplashKit.DrawText("Press L to load new script", Color.Orange, 280, 400);

                    if (SplashKit.KeyTyped(KeyCode.LKey))
                    {
                        script = SplashKit.LoadAnimationScript("kermit", "kermit.txt");
                        scriptLoaded = true;
                        anim = SplashKit.CreateAnimation(script, "SplashKitOnlineDemo");
                        animationExists = true;
                    }
                }

                SplashKit.DrawText("Press ESC to exit", Color.Gray, 320, 500);

                SplashKit.RefreshScreen(60);
            }

            // Final cleanup
            if (animationExists)
            {
                SplashKit.FreeAnimation(anim);
            }
            if (scriptLoaded)
            {
                SplashKit.FreeAnimationScript(script);
            }

            SplashKit.CloseAllWindows();
        }
    }
}
