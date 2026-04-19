using SplashKitSDK;

namespace LoadAnimationScriptExample
{
    public class Program
    {
        public static void Main()
        {
            SplashKit.WriteLine("Loading animation script...");

            AnimationScript script = SplashKit.LoadAnimationScript("WalkingScript", "kermit.txt");

            SplashKit.WriteLine("Script name:");
            SplashKit.WriteLine(SplashKit.AnimationScriptName(script));

            SplashKit.WriteLine("Animations in script: " + SplashKit.AnimationCount(script).ToString());

            SplashKit.FreeAnimationScript(script);
        }
    }
}
