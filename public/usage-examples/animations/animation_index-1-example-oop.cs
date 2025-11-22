using SplashKitSDK;

public class Program
{
    public static void Main()
    {
        AnimationScript script = new AnimationScript("WalkingScript", "kermit.txt");
        int idx = SplashKit.AnimationIndex(script, "WalkFront");
        SplashKit.write_line($"Index of WalkFront: {idx}");

        SplashKit.FreeAnimationScript(script);
    }
}
