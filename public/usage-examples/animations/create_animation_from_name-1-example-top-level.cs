using SplashKitSDK;

public class Program
{
    public static void Main()
    {
        var script = SplashKit.LoadAnimationScript("WalkingScript", "kermit.txt");

        // Create animation using the name identifier from script
        var anim = SplashKit.CreateAnimation(script, "WalkFront");
        SplashKit.WriteLine($"Created animation -> name: {anim.Name}");

        anim.Free();
        script.Free();
    }
}
