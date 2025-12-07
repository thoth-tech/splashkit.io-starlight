using SplashKitSDK;

namespace LoadAnimationScriptExample
{
    public class Program
    {
        public static void Main()
        {
            SplashKit.OpenWindow("Load Animation Script", 800, 600);

            // Load an animation script from file
            AnimationScript kermitScript = SplashKit.LoadAnimationScript("kermit", "kermit.txt");

            // Check if the script was loaded successfully
            if (SplashKit.HasAnimationScript("kermit"))
            {
                SplashKit.ClearScreen(Color.White);
                SplashKit.DrawText("Animation Script Loaded Successfully!", Color.Green, 250, 280);
                SplashKit.DrawText("Script Name: kermit", Color.Black, 300, 320);
                SplashKit.DrawText($"Animation Count: {SplashKit.AnimationCount(kermitScript)}", Color.Blue, 280, 360);
                SplashKit.RefreshScreen();
            }

            SplashKit.Delay(5000);

            // Free the animation script when done
            SplashKit.FreeAnimationScript(kermitScript);

            SplashKit.CloseAllWindows();
        }
    }
}
