using SplashKitSDK;

public class Program
{
    public static void Main()
    {
        var script = SplashKit.LoadAnimationScript("WalkingScript", "kermit.txt");
        var anim = SplashKit.CreateAnimation(script, "WalkFront");

        // Using instance method to update
        anim.Update();
        SplashKit.WriteLine("Animation updated (default update).");

        anim.Free();
        script.Free();
    }
}
