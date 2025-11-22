using SplashKitSDK;

public class Program
{
    public static void Main()
    {
        // Register 'WalkingScript' from the kermit.txt file
        var script = SplashKit.LoadAnimationScript("WalkingScript", "kermit.txt");
        SplashKit.WriteLine("Loaded animation script -> name: WalkingScript");

        // Cleanup when finished
        SplashKit.FreeAnimationScript(script);
    }
}
