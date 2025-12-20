using SplashKitSDK;

public class Program
{
    public static void Main()
    {
        var script = SplashKit.LoadAnimationScript("WalkingScript", "kermit.txt");
        var anim = SplashKit.CreateAnimation(script, "WalkFront");

        // Instance update with pct and sound flag
        anim.Update(0.25f, true);
        SplashKit.WriteLine("Animation updated (pct=0.25, with_sound=true).");

        anim.Free();
        script.Free();
    }
}
