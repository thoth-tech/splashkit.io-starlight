using SplashKitSDK;

public class Example
{
    public static void Main()
    {
        AnimationScript script = SplashKit.LoadAnimationScript("WalkingScript", "kermit.txt");

        // Free all animation scripts
        Animation.FreeAll();
        SplashKit.WriteLine("All animation scripts freed.");

        // cleanup
        script.Free();
    }
}
