using SplashKitSDK;

namespace FreeAnimationExample
{
    public class Program
    {
        public static void Main()
        {
            AnimationScript script = SplashKit.LoadAnimationScript("WalkingScript", "kermit.txt");
            Animation anim = SplashKit.CreateAnimation(script, "WalkFront");

            SplashKit.WriteLine("Freeing animation: " + SplashKit.AnimationName(anim));
            SplashKit.FreeAnimation(anim);

            SplashKit.FreeAnimationScript(script);
        }
    }
}
