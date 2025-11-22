using SplashKitSDK;

public class Program
{
    public static void Main()
    {
        var script = SplashKit.LoadAnimationScript("WalkingScript", "kermit.txt");
        var anim = SplashKit.CreateAnimation(script, "WalkFront");

        // Instance method version takes a boolean for sound
        anim.Restart(true);
        SplashKit.WriteLine("Animation restarted (with_sound=true).");

        anim.Free();
        script.Free();
    }
}
