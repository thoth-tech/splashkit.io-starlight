using SplashKitSDK;

public class Example
{
    public static void Main()
    {
        AnimationScript script = SplashKit.LoadAnimationScript("WalkingScript", "kermit.txt");
        Animation anim = SplashKit.CreateAnimation();

        anim.Assign(script, "WalkFront");
        SplashKit.WriteLine($"Assigned animation -> script index: {script.AnimationIndex("WalkFront")}");

        anim.Free();
        script.Free();
    }
}
