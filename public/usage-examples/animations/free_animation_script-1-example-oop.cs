using SplashKitSDK;

namespace FreeAnimationScriptExample
{
    public class Program
    {
        public static void Main()
        {
            AnimationScript script = SplashKit.LoadAnimationScript("WalkingScript", "kermit.txt");

            SplashKit.WriteLine("Freeing animation script: " + SplashKit.AnimationScriptName(script));
            SplashKit.FreeAnimationScript(script);
        }
    }
}
