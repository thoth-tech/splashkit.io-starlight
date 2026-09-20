using SplashKitSDK;

namespace AnimationEnteredFrameExample
{
    public class Program
    {
        public static void Main()
        {
            SplashKit.OpenWindow("Animation Frame Tracker", 800, 500);

            AnimationScript frameScript =
                SplashKit.LoadAnimationScript("FrameCycle", "frame_cycle.txt");
            Animation frameAnimation =
                SplashKit.CreateAnimation(frameScript, "Cycle");

            bool enteredNewFrame = false;
            int frameNoticeCountdown = 0;
            int currentFrame = 0;

            while (!SplashKit.QuitRequested())
            {
                SplashKit.ProcessEvents();
                SplashKit.UpdateAnimation(frameAnimation);

                enteredNewFrame = SplashKit.AnimationEnteredFrame(frameAnimation);
                currentFrame = SplashKit.AnimationCurrentCell(frameAnimation);

                // Keep the triggered message visible long enough to be noticed.
                if (enteredNewFrame)
                {
                    frameNoticeCountdown = 30;
                }
                else if (frameNoticeCountdown > 0)
                {
                    frameNoticeCountdown--;
                }

                SplashKit.ClearScreen(SplashKit.ColorWhite());
                SplashKit.DrawText("Animation Frame Tracker", SplashKit.ColorBlack(), 270, 60);
                SplashKit.DrawText("The highlighted circle shows the current animation frame.", SplashKit.ColorBlack(), 175, 100);

                SplashKit.FillCircle(SplashKit.ColorGray(), 160, 240, 50);
                SplashKit.FillCircle(SplashKit.ColorGray(), 320, 240, 50);
                SplashKit.FillCircle(SplashKit.ColorGray(), 480, 240, 50);
                SplashKit.FillCircle(SplashKit.ColorGray(), 640, 240, 50);

                if (currentFrame == 0)
                {
                    SplashKit.FillCircle(SplashKit.ColorBlue(), 160, 240, 50);
                }
                else if (currentFrame == 1)
                {
                    SplashKit.FillCircle(SplashKit.ColorBlue(), 320, 240, 50);
                }
                else if (currentFrame == 2)
                {
                    SplashKit.FillCircle(SplashKit.ColorBlue(), 480, 240, 50);
                }
                else if (currentFrame == 3)
                {
                    SplashKit.FillCircle(SplashKit.ColorBlue(), 640, 240, 50);
                }

                SplashKit.DrawText("Frame 1", SplashKit.ColorBlack(), 130, 310);
                SplashKit.DrawText("Frame 2", SplashKit.ColorBlack(), 290, 310);
                SplashKit.DrawText("Frame 3", SplashKit.ColorBlack(), 450, 310);
                SplashKit.DrawText("Frame 4", SplashKit.ColorBlack(), 610, 310);

                if (frameNoticeCountdown > 0)
                {
                    SplashKit.DrawText("A new animation frame was entered!", SplashKit.ColorGreen(), 245, 390);
                }
                else
                {
                    SplashKit.DrawText("Waiting for the next frame...", SplashKit.ColorBlack(), 275, 390);
                }

                SplashKit.RefreshScreen(60);
            }

            SplashKit.FreeAnimation(frameAnimation);
            SplashKit.FreeAnimationScript(frameScript);
            SplashKit.CloseAllWindows();
        }
    }
}
