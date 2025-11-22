using SplashKitSDK;

public class Example
{
    public static void Main()
    {
        AnimationScript script = SplashKit.LoadAnimationScript("WalkingScript", "kermit.txt");
        Animation anim = SplashKit.CreateAnimation();

        // assign by index
        anim.Assign(script, 0);
        SplashKit.WriteLine("Assigned animation -> script identifier index: 0");

        anim.Free();
        script.Free();
    }
}
