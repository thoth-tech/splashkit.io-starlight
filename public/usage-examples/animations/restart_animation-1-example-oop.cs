using SplashKitSDK;

namespace RestartAnimationExample
{
    public class Program
    {
        public static void Main()
        {
            AnimationScript script = SplashKit.LoadAnimationScript("WalkingScript", "kermit.txt");
            Animation anim = SplashKit.CreateAnimation(script, "WalkFront");

            SplashKit.WriteLine("Updating animation a few times...");
            for (int i = 0; i < 10; i++)
            {
                SplashKit.UpdateAnimation(anim);
            }

            SplashKit.WriteLine("Restarting animation...");
            SplashKit.RestartAnimation(anim);

            SplashKit.FreeAnimation(anim);
            SplashKit.FreeAnimationScript(script);
        }
    }
}
