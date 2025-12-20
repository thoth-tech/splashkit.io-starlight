using SplashKitSDK;

public class Program
{
    public static void Main()
    {
        var script = SplashKit.LoadAnimationScript("WalkingScript", "kermit.txt");

        // Dispose of loaded frame resources
        SplashKit.FreeAnimationScript(script);
        SplashKit.WriteLine("Animation script freed.");
    }
}
