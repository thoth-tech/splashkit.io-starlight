using SplashKitSDK;

public class Program
{
    public static void Main()
    {
        // Load the script under a name and later use the name to free it
        SplashKit.LoadAnimationScript("WalkingScript", "kermit.txt");

        // Free via static helper by name
        SplashKit.FreeAnimationScript("WalkingScript");
        SplashKit.WriteLine("Animation script freed (by name).");
    }
}
