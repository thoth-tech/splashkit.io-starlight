using SplashKitSDK;

public class Program
{
    public static void Main()
    {
        var script = SplashKit.LoadAnimationScript("WalkingScript", "kermit.txt");
        var name = script.Name; // AnimationScript.Name
        SplashKit.WriteLine($"Script name: {name}");
        script.Free();
    }
}
