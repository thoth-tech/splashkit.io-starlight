using SplashKitSDK;

public class Program
{
    public static void Main()
    {
        var script = SplashKit.LoadAnimationScript("WalkingScript", "kermit.txt");
        bool found = SplashKit.HasAnimationNamed(script, "WalkFront");
        SplashKit.WriteLine($"Has animation named: {found.ToString().ToLower()}");

        SplashKit.FreeAnimationScript(script);
    }
}
