using SplashKitSDK;

public class Program
{
    public static void Main()
    {
        var script = SplashKit.LoadAnimationScript("WalkingScript", "kermit.txt");

        // The script instance exposes an instance method freeing its frame data
        script.Free();
        SplashKit.WriteLine("Animation script freed.");
    }
}
