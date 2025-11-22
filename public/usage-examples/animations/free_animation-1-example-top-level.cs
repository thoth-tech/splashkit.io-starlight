using SplashKitSDK;

public class Program
{
    public static void Main()
    {
        // Load animation script and create animation from the script name
        var script = SplashKit.LoadAnimationScript("WalkingScript", "kermit.txt");
        var anim = SplashKit.CreateAnimation(script, "WalkFront");

        // Free the animation instance when no longer needed
        SplashKit.FreeAnimation(anim);
        SplashKit.WriteLine("Animation freed.");

        // Clean up the script resource too
        SplashKit.FreeAnimationScript(script);
    }
}
