using SplashKitSDK;

public class Program
{
    public static void Main()
    {
        var script = SplashKit.LoadAnimationScript("WalkingScript", "kermit.txt");

        // Create animation by name and play starting-frame sound
        var anim = SplashKit.CreateAnimation(script, "WalkFront", true);
        SplashKit.WriteLine($"Created animation by name -> animation: {anim.Name}");

        anim.Free();
        script.Free();
    }
}
