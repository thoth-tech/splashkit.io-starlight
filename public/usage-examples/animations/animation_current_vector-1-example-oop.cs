using SplashKitSDK;

public class Program
{
    public static void Main()
    {
        AnimationScript script = new AnimationScript("ExplosionScript", "explosion.txt");
        Animation anim = SplashKit.CreateAnimation(script, "Explode");
        Vector2D v = SplashKit.AnimationCurrentVector(anim);
        SplashKit.write_line($"Current vector: x={v.x} y={v.y}");

        SplashKit.FreeAnimation(anim);
        SplashKit.FreeAnimationScript(script);
    }
}
