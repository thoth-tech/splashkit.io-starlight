using SplashKitSDK;

namespace CurrentClipExample
{
    class Program
    {
        static void Main()
        {
            var window = new Window("Current Clip Example", 400, 400);

            //Clip the window to a 200×200 region at (100,100)
            SplashKit.SetClip(100, 100, 200, 200);

            //Fill that region with red (with a rectangle)
            SplashKit.FillRectangle(Color.Red, 100, 100, 200, 200);

            //Retrieve the clip bounds
            var clip = SplashKit.CurrentClip();

            //Exit out of the clip
            SplashKit.PopClip();

            //Outline the old clip in green as a rectangle
            SplashKit.DrawRectangle(Color.Green,
                                    clip.X, clip.Y,
                                    clip.Width, clip.Height);

            SplashKit.RefreshScreen();
            SplashKit.Delay(5000);
        }
    }
}
