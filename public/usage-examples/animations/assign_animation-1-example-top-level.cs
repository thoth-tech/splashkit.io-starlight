using SplashKitSDK;

public class Program
{
    public static void Main()
    {
        var script = SplashKit.LoadAnimationScript("WalkingScript", "kermit.txt");
        var anim = SplashKit.CreateAnimation(script, "WalkFront");

        // switch to named animation in same script
        SplashKit.AssignAnimation(anim, "Dance");
        SplashKit.WriteLine($"Animation assigned to: {anim.Name}");

        anim.Free();
        script.Free();
    }
}
