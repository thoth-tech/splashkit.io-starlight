using SplashKitSDK;

public class Program
{
    public static void Main()
    {
        SplashKit.LoadAnimationScript("WalkingScript", "kermit.txt");

        bool present = SplashKit.HasAnimationScript("WalkFront");
        SplashKit.WriteLine($"Has animation script: {present.ToString().ToLower()}");

        SplashKit.FreeAnimationScript("WalkingScript");
    }
}
