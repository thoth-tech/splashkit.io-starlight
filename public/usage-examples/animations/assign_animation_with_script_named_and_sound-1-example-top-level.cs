using SplashKitSDK;

public class Program
{
    public static void Main()
    {
        var anim = SplashKit.CreateAnimation();
        var script = SplashKit.AnimationScriptNamed("WalkingScript");

        SplashKit.AssignAnimation(anim, "WalkingScript", "WalkFront", true);
        SplashKit.WriteLine($"Assigned WalkFront -> script name: {script.Name}");

        anim.Free();
        script.Free();
    }
}
