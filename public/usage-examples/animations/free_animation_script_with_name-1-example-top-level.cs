using SplashKitSDK;

public class Program
{
    public static void Main()
    {
        // Load script and give it a name
        SplashKit.LoadAnimationScript("WalkingScript", "kermit.txt");

        // Free by name
        SplashKit.FreeAnimationScript("WalkingScript");
        SplashKit.WriteLine("Animation script freed (by name).");
    }
}
