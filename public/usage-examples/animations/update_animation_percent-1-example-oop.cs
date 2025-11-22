using SplashKitSDK;

public class Program
{
    public static void Main()
    {
        var script = SplashKit.LoadAnimationScript("WalkingScript", "kermit.txt");
        var anim = SplashKit.CreateAnimation(script, "WalkFront");

        // Instance update with pct
        anim.Update(0.25f);
        SplashKit.WriteLine("Animation updated (pct=0.25).");

        anim.Free();
        script.Free();
    }
}
