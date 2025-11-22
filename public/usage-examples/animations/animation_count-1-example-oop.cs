using SplashKitSDK;

public class Program
{
    public static void Main()
    {
        AnimationScript script = new AnimationScript("WalkingScript", "kermit.txt");
        int count = SplashKit.AnimationCount(script);
        SplashKit.write_line($"This script contains {count} animations.");
    }
}
