using SplashKitSDK;

public class Example
{
    public static void Main()
    {
        AnimationScript script = SplashKit.LoadAnimationScript("WalkingScript", "kermit.txt");
        var name = script.Name;
        SplashKit.WriteLine($"Script name: {name}");
        script.Free();
    }
}
