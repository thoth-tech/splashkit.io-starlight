using SplashKitSDK;

namespace CurrentClipExample
{
    public class Program
    {
        public static void Main()
        {
            SplashKit.OpenWindow("Current Clip Example", 400, 400);

            //Fill that region with red (with a rectangle)
            var region = new Rectangle { X = 100, Y = 100, Width = 200, Height = 200 };

            while (!SplashKit.QuitRequested())
            {
                SplashKit.ProcessEvents();
                SplashKit.ClearScreen(Color.White);
                //Clip the window to the rectangle
                SplashKit.SetClip(region);

                //Fill that region with red
                SplashKit.FillRectangle(Color.Red, region);

                //Retrieve the clip bounds
                Rectangle clip = SplashKit.CurrentClip();

                //Exit out of the clip
                SplashKit.PopClip();

                //Outline the old clip in green as a rectangle
                SplashKit.DrawRectangle(Color.Green,
                                        clip.X, clip.Y,
                                        clip.Width, clip.Height);

                SplashKit.RefreshScreen();
            }

            SplashKit.CloseWindow("Current Clip Example");
        }
    }
}
