using SplashKitSDK;

public class Example
{
    public static void Main()
    {
        AnimationScript script = SplashKit.LoadAnimationScript("WalkingScript", "kermit.txt");

        // Create animation by identifier name and request sound playback
        Animation anim = script.CreateAnimation("WalkFront", true);
        SplashKit.WriteLine($"Created animation by name -> animation: {anim.Name}");

        anim.Free();
        script.Free();
    }
}
