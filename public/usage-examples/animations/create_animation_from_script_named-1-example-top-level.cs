using SplashKitSDK;

public class Program
{
    public static void Main()
    {
        // Create animation using a named script
        var anim = SplashKit.CreateAnimation("WalkingScript", "WalkFront");
        SplashKit.WriteLine($"Created animation from script name -> name: {anim.Name}");

        anim.Free();
    }
}
