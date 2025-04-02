using SplashKitSDK;

namespace PushClipExample
{
    public class Program
    {
        public static void Main()
        {
            SplashKit.OpenWindow("Push Clip Example", 800, 600);

            var clipRect = SplashKit.RectangleFrom(400, 100, 200, 400);
            SplashKit.PushClip(clipRect);

            var cornerClipRect = SplashKit.RectangleFrom(200, 300, 400, 200);
            SplashKit.PushClip(cornerClipRect);

            SplashKit.ClearScreen(Color.White);
            SplashKit.FillCircle(Color.Red, 400, 300, 200);
            SplashKit.RefreshScreen();

            SplashKit.Delay(4000);

            SplashKit.CloseAllWindows();
        }
    }
}