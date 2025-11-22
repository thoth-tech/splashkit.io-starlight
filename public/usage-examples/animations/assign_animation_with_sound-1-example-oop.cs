using SplashKitSDK;

public class Example
{
    public static void Main()
    {
        AnimationScript script = SplashKit.LoadAnimationScript("WalkingScript", "kermit.txt");
        Animation anim = SplashKit.CreateAnimation(script, "WalkFront");

        anim.Assign("WalkFront", true);
        SplashKit.WriteLine($"Assigned WalkFront with sound -> animation name: {anim.Name}");

        anim.Free();
        script.Free();
    }
}
