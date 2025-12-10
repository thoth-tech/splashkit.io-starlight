using SplashKitSDK;

namespace CreateAnimationExample
{
    public class Program
    {
        public static void Main()
        {
            SplashKit.OpenWindow("Create Animation Example", 800, 600);

            // Load the animation script
            AnimationScript script = SplashKit.LoadAnimationScript("explosion", "explosion.txt");

            // Create an animation from the script
            Animation anim = SplashKit.CreateAnimation(script, "Explosion");

            // Display animation information
            SplashKit.ClearScreen(Color.White);
            SplashKit.DrawText("Animation Created Successfully!", Color.Green, 280, 200);
            SplashKit.DrawText("Animation Name: Explosion", Color.Black, 260, 250);
            SplashKit.DrawText($"Current Cell: {SplashKit.AnimationCurrentCell(anim)}", Color.Blue, 300, 300);
            SplashKit.DrawText($"Animation Ended: {(SplashKit.AnimationEnded(anim) ? "Yes" : "No")}", Color.Purple, 300, 350);
            SplashKit.DrawText($"Frame Time: {SplashKit.AnimationFrameTime(anim)}", Color.Orange, 300, 400);
            SplashKit.RefreshScreen();

            SplashKit.Delay(5000);

            // Free resources
            SplashKit.FreeAnimation(anim);
            SplashKit.FreeAnimationScript(script);

            SplashKit.CloseAllWindows();
        }
    }
}
