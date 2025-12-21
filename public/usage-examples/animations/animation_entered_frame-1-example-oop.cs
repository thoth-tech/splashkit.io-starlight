using SplashKitSDK;

namespace AnimationEnteredFrameExample
{
    public class Program
    {
        public static void Main()
        {
            AnimationScript script = SplashKit.LoadAnimationScript("WalkingScript", "kermit.txt");
            Animation anim = SplashKit.CreateAnimation(script, "WalkFront");

            SplashKit.WriteLine("Updating animation and checking frame entry...");

            for (int i = 0; i < 10; i++)
            {
                SplashKit.UpdateAnimation(anim);
                SplashKit.Delay(100);

                if (SplashKit.AnimationEnteredFrame(anim))
                {
                    SplashKit.WriteLine("Entered a new frame!");
                    SplashKit.WriteLine("Current cell: " + SplashKit.AnimationCurrentCell(anim).ToString());
                }
            }

            SplashKit.FreeAnimation(anim);
            SplashKit.FreeAnimationScript(script);
        }
    }
}
