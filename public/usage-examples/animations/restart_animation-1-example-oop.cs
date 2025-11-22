using SplashKitSDK;

public class Program
{
    public static void Main()
    {
        var script = SplashKit.LoadAnimationScript("WalkingScript", "kermit.txt");
        var anim = SplashKit.CreateAnimation(script, "WalkFront");

        // Instance method to restart
        anim.Restart();
        SplashKit.WriteLine("Animation restarted.");

        anim.Free();
        script.Free();
    }
}
