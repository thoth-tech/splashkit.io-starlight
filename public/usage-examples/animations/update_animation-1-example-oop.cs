using SplashKitSDK;

namespace UpdateAnimationExample
{
    public class Program
    {
        public static void Main()
        {
            SplashKit.OpenWindow("Color Cycle Animation", 400, 400);

            // Build a 4-frame sprite sheet in memory (each cell is 64x64)
            Bitmap sheet = new Bitmap("sheet", 256, 64);
            sheet.FillRectangle(Color.Red, 0, 0, 64, 64);
            sheet.FillRectangle(Color.Green, 64, 0, 64, 64);
            sheet.FillRectangle(Color.Blue, 128, 0, 64, 64);
            sheet.FillRectangle(Color.Yellow, 192, 0, 64, 64);
            sheet.SetCellDetails(64, 64, 4, 1, 4);

            // Load the animation script and create the animation
            AnimationScript script = new AnimationScript("color_cycle", "color_cycle.txt");
            Animation anim = script.CreateAnimation("ColorCycle");

            while (!SplashKit.QuitRequested())
            {
                SplashKit.ProcessEvents();
                SplashKit.ClearScreen(Color.White);

                // Draw the current animation frame centered on the window
                sheet.Draw(168, 168, SplashKit.OptionWithAnimation(anim));

                // Advance the animation to the next frame
                anim.Update();

                SplashKit.RefreshScreen(60);
            }

            // Release resources
            anim.Free();
            script.Free();
            SplashKit.CloseAllWindows();
        }
    }
}
