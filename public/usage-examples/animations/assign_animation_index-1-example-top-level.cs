using SplashKitSDK;

public class Program
{
    public static void Main()
    {
        var script = SplashKit.LoadAnimationScript("WalkingScript", "kermit.txt");
        var anim = SplashKit.CreateAnimation();

        SplashKit.AssignAnimation(anim, script, 0); // first identifier index
        SplashKit.WriteLine($"Assigned animation -> script identifier index: 0");

        anim.Free();
        script.Free();
    }
}
