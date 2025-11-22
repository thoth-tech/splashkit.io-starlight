using SplashKitSDK;

public class Program
{
    public static void Main()
    {
        var script = SplashKit.LoadAnimationScript("WalkingScript", "kermit.txt");
        var found = script.HasAnimationNamed("WalkFront");
        SplashKit.WriteLine($"Has animation named: {found.ToString().ToLower()}");

        script.Free();
    }
}
