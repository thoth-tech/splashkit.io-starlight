using SplashKitSDK;

public class Program
{
    public static void Main()
    {
        AnimationScript script = new AnimationScript("ExplosionScript", "explosion.txt");
        Animation anim = SplashKit.CreateAnimation(script, "explosion");
        bool ended = SplashKit.AnimationEnded(anim);
        SplashKit.write_line($"Animation ended? {ended}");

        SplashKit.FreeAnimation(anim);
        SplashKit.FreeAnimationScript(script);
    }
}
