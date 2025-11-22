using SplashKitSDK;

public class Program
{
    public static void Main()
    {
        var script = SplashKit.LoadAnimationScript("WalkingScript", "kermit.txt");
        var anim = SplashKit.CreateAnimation(script, "WalkFront");

        // Free animation via instance method
        anim.Free();
        SplashKit.WriteLine("Animation freed.");

        script.Free();
    }
}
