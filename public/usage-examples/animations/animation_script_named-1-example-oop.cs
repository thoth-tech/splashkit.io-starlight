using SplashKitSDK;

public class Example
{
    public static void Main()
    {
        AnimationScript script = SplashKit.AnimationScriptNamed("WalkingScript");
        var name = script.Name;
        SplashKit.WriteLine($"Named script loaded: {name}");
        script.Free();
    }
}
