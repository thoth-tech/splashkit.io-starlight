using SplashKitSDK;

public class Program
{
    public static void Main()
    {
        var script = SplashKit.LoadAnimationScript("WalkingScript", "kermit.txt");
        var anim = SplashKit.CreateAnimation(script, "WalkFront");

        // Update with pct and allow any frame sound to play
        SplashKit.UpdateAnimation(anim, 0.25f, true);
        SplashKit.WriteLine("Animation updated (pct=0.25, with_sound=true).");

        SplashKit.FreeAnimation(anim);
        SplashKit.FreeAnimationScript(script);
    }
}
