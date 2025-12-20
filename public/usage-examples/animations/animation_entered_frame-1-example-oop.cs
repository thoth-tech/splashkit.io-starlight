using SplashKitSDK;

public class Program
{
    public static void Main()
    {
        AnimationScript script = new AnimationScript("ExplosionScript", "explosion.txt");
        Animation anim = SplashKit.CreateAnimation(script, "explosion");
        bool entered = SplashKit.AnimationEnteredFrame(anim);
        SplashKit.write_line($"Animation entered frame? {entered}");

        SplashKit.FreeAnimation(anim);
        SplashKit.FreeAnimationScript(script);
    }
}
