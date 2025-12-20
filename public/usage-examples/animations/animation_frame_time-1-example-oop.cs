using SplashKitSDK;

public class Program
{
    public static void Main()
    {
        AnimationScript script = new AnimationScript("ExplosionScript", "explosion.txt");
        Animation anim = SplashKit.CreateAnimation(script, "explosion");
        float t = SplashKit.AnimationFrameTime(anim);
        SplashKit.write_line($"Time spent in current frame: {t}");

        SplashKit.FreeAnimation(anim);
        SplashKit.FreeAnimationScript(script);
    }
}
