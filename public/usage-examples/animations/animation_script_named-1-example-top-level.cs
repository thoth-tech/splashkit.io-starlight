using SplashKitSDK;

public class Program
{
    public static void Main()
    {
        var script = SplashKit.AnimationScriptNamed("WalkingScript");
        var name = script.Name;
        SplashKit.WriteLine($"Named script loaded: {name}");
        script.Free();
    }
}
