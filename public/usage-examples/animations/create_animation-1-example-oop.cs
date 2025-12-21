using SplashKitSDK;

namespace CreateAnimationExample
{
    public class Program
    {
        public static void Main()
        {
            AnimationScript script = SplashKit.LoadAnimationScript("WalkingScript", "kermit.txt");

            SplashKit.WriteLine("Creating animation...");
            Animation anim = SplashKit.CreateAnimation(script, "WalkFront");

            SplashKit.WriteLine("Animation name:");
            SplashKit.WriteLine(SplashKit.AnimationName(anim));

            SplashKit.FreeAnimation(anim);
            SplashKit.FreeAnimationScript(script);
        }
    }
}
