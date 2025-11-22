using SplashKitSDK;

public class Example
{
    public static void Main()
    {
        // Create animation from a script name
        Animation anim = SplashKit.CreateAnimation("WalkingScript", "WalkFront");
        SplashKit.WriteLine($"Created animation from script name -> name: {anim.Name}");

        anim.Free();
    }
}
