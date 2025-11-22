using SplashKitSDK;

public class Program
{
    public static void Main()
    {
        var script = SplashKit.LoadAnimationScript("WalkingScript", "kermit.txt");
        var anim = SplashKit.CreateAnimation(script, "WalkFront");

        // Switch to WalkFront and play sound if present
        SplashKit.AssignAnimation(anim, "WalkFront", true);
        SplashKit.WriteLine($"Assigned WalkFront with sound -> animation name: {anim.Name}");

        anim.Free();
        script.Free();
    }
}
