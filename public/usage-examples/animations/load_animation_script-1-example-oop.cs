using SplashKitSDK;

public class Program
{
    public static void Main()
    {
        // Load the animation script under a name
        var script = SplashKit.LoadAnimationScript("WalkingScript", "kermit.txt");
        SplashKit.WriteLine("Loaded animation script -> name: WalkingScript");

        // Use instance method to clean up
        script.Free();
    }
}
