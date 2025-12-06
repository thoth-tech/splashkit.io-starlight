using SplashKitSDK;

public class Program
{
    public static void Main()
    {
        var script = SplashKit.LoadAnimationScript("WalkingScript", "kermit.txt");
        var anim = SplashKit.CreateAnimation(script, "WalkFront");

        // Update by a given percentage/time delta
        SplashKit.UpdateAnimation(anim, 0.25f);
        SplashKit.WriteLine("Animation updated (pct=0.25).");

        SplashKit.FreeAnimation(anim);
        SplashKit.FreeAnimationScript(script);
    }
}
