using SplashKitSDK;

public class Program
{
    public static void Main()
    {
        var script = SplashKit.LoadAnimationScript("WalkingScript", "kermit.txt");
        var anim = SplashKit.CreateAnimation();

        SplashKit.AssignAnimation(anim, script, "WalkFront");
        SplashKit.WriteLine($"Assigned animation -> script index: {SplashKit.AnimationIndex(script, "WalkFront")}");

        anim.Free();
        script.Free();
    }
}
