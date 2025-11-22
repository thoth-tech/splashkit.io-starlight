using SplashKitSDK;

public class Example
{
    public static void Main()
    {
        AnimationScript script = SplashKit.LoadAnimationScript("WalkingScript", "kermit.txt");

        // Create animation from index with sound
        Animation anim = SplashKit.CreateAnimation(script, 0, true);
        SplashKit.WriteLine($"Created animation from index 0 -> name: {anim.Name}");

        anim.Free();
        script.Free();
    }
}
