using SplashKitSDK;

public class Example
{
    public static void Main()
    {
        AnimationScript script = SplashKit.LoadAnimationScript("WalkingScript", "kermit.txt");
        Animation anim = SplashKit.CreateAnimation(script, "WalkFront");

        // Switch within the current script to a different named animation
        anim.Assign("Dance");
        SplashKit.WriteLine($"Animation assigned to: {anim.Name}");

        anim.Free();
        script.Free();
    }
}
