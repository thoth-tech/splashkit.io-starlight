using SplashKitSDK;

public class Program
{
    public static void Main()
    {
        var script = SplashKit.LoadAnimationScript("WalkingScript", "kermit.txt");

        // free all loaded animation scripts
        SplashKit.FreeAllAnimationScripts();
        SplashKit.WriteLine("All animation scripts freed.");

        // safe to call free explicitly here as example cleanup
        script.Free();
    }
}
