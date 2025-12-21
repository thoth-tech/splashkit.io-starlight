using SplashKitSDK;

namespace AnimationFrameTimeExample
{
    public class Program
    {
        public static void Main()
        {
            AnimationScript script = SplashKit.LoadAnimationScript("WalkingScript", "kermit.txt");
            Animation anim = SplashKit.CreateAnimation(script, "WalkFront");

            SplashKit.WriteLine("Frame time in current frame:");

            for (int i = 0; i < 5; i++)
            {
                SplashKit.UpdateAnimation(anim);
                SplashKit.Delay(200);

                SplashKit.WriteLine("Frame time: " + SplashKit.AnimationFrameTime(anim).ToString());
            }

            SplashKit.FreeAnimation(anim);
            SplashKit.FreeAnimationScript(script);
        }
    }
}
