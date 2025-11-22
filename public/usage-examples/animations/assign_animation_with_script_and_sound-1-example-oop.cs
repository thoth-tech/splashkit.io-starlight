using SplashKitSDK;

public class Example
{
    public static void Main()
    {
        AnimationScript script = SplashKit.LoadAnimationScript("WalkingScript", "kermit.txt");
        Animation anim = SplashKit.CreateAnimation();

        anim.Assign(script, "WalkFront", true);
        SplashKit.WriteLine($"Assigned WalkFront -> script identifier index: {script.AnimationIndex("WalkFront")}");

        anim.Free();
        script.Free();
    }
}
