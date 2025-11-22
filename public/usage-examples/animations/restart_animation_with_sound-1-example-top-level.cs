using SplashKitSDK;

public class Program
{
    public static void Main()
    {
        var script = SplashKit.LoadAnimationScript("WalkingScript", "kermit.txt");
        var anim = SplashKit.CreateAnimation(script, "WalkFront");

        // Restart and allow any first-frame sound to play
        SplashKit.RestartAnimation(anim, true);
        SplashKit.WriteLine("Animation restarted (with_sound=true).");

        SplashKit.FreeAnimation(anim);
        SplashKit.FreeAnimationScript(script);
    }
}
