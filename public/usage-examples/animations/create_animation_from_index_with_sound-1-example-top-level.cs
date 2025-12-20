using SplashKitSDK;

public class Program
{
    public static void Main()
    {
        var script = SplashKit.LoadAnimationScript("WalkingScript", "kermit.txt");

        // Create new animation from index 0 and play sound if available
        var anim = SplashKit.CreateAnimation(script, 0, true);
        SplashKit.WriteLine($"Created animation from index 0 -> name: {anim.Name}");

        anim.Free();
        script.Free();
    }
}
