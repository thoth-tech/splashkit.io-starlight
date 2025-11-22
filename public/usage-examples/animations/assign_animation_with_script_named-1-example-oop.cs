using SplashKitSDK;

public class Example
{
    public static void Main()
    {
        Animation anim = SplashKit.CreateAnimation();
        AnimationScript script = SplashKit.AnimationScriptNamed("WalkingScript");

        anim.Assign(script, "WalkFront");
        SplashKit.WriteLine($"Assigned WalkFront -> script name: {script.Name}");

        anim.Free();
        script.Free();
    }
}
