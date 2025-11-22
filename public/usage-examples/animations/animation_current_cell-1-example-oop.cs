using SplashKitSDK;

public class Program
{
    public static void Main()
    {
        AnimationScript script = new AnimationScript("WalkingScript", "kermit.txt");
        Animation anim = SplashKit.CreateAnimation(script, "WalkFront");
        int cell = SplashKit.AnimationCurrentCell(anim);
        SplashKit.write_line($"Current cell index: {cell}");

        // Cleanup
        SplashKit.FreeAnimation(anim);
        SplashKit.FreeAnimationScript(script);
    }
}
