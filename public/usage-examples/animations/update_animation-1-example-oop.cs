using SplashKitSDK;

namespace UpdateAnimationExample
{
    public class Program
    {
        public static void Main()
        {
            AnimationScript script = SplashKit.LoadAnimationScript("WalkingScript", "kermit.txt");
            Animation anim = SplashKit.CreateAnimation(script, "WalkFront");

            SplashKit.WriteLine("Updating animation...");

            for (int i = 0; i < 5; i++)
            {
                SplashKit.UpdateAnimation(anim);
                SplashKit.Delay(100);

                SplashKit.WriteLine("Current cell: " + SplashKit.AnimationCurrentCell(anim).ToString());
            }

            SplashKit.FreeAnimation(anim);
            SplashKit.FreeAnimationScript(script);
        }
    }
}
