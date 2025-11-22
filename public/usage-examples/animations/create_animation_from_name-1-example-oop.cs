using SplashKitSDK;

public class Example
{
    public static void Main()
    {
        AnimationScript script = SplashKit.LoadAnimationScript("WalkingScript", "kermit.txt");

        // Create animation using the named identifier
        Animation anim = script.CreateAnimation("WalkFront");
        SplashKit.WriteLine($"Created animation -> name: {anim.Name}");

        anim.Free();
        script.Free();
    }
}
