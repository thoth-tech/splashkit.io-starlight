using SplashKitSDK;

namespace AnimationEndedExample
{
    public class Program
    {
        public static void Main()
        {
            AnimationScript script = SplashKit.LoadAnimationScript("ExplosionScript", "explosion.txt");
            Animation anim = SplashKit.CreateAnimation(script, "explosion");

            SplashKit.WriteLine("Has animation ended?");
            SplashKit.WriteLine(SplashKit.AnimationEnded(anim).ToString());

            for (int i = 0; i < 10; i++)
            {
                SplashKit.UpdateAnimation(anim);
                SplashKit.Delay(100);

                SplashKit.WriteLine("Current cell: " + SplashKit.AnimationCurrentCell(anim).ToString());

                if (SplashKit.AnimationEnded(anim))
                {
                    SplashKit.WriteLine("Animation ended!");
                    break;
                }
            }

            SplashKit.FreeAnimation(anim);
            SplashKit.FreeAnimationScript(script);
        }
    }
}
