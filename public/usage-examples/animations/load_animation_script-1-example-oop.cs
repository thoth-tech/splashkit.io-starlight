using SplashKitSDK;

namespace LoadAnimationScriptExample
{
    public class Program
    {
        public static void Main()
        {
            SplashKit.OpenWindow("Load Animation Script", 800, 600);

            // Load an animation script from file
            AnimationScript explosionScript = SplashKit.LoadAnimationScript("explosion", "explosion.txt");

            // Check if the script was loaded successfully
            if (SplashKit.HasAnimationScript("explosion"))
            {
                SplashKit.ClearScreen(Color.White);
                SplashKit.DrawText("Animation Script Loaded Successfully!", Color.Green, 250, 280);
                SplashKit.DrawText("Script Name: explosion", Color.Black, 300, 320);
                SplashKit.DrawText($"Animation Count: {SplashKit.AnimationCount(explosionScript)}", Color.Blue, 280, 360);
                SplashKit.RefreshScreen();
            }

            SplashKit.Delay(5000);

            // Free the animation script when done
            SplashKit.FreeAnimationScript(explosionScript);

            SplashKit.CloseAllWindows();
        }
    }
}
