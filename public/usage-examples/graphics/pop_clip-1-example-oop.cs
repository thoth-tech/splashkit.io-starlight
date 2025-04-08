using SplashKitSDK;

namespace PopClip
{
    class tester
    {
        static void Main()
        {
            Window window = new Window("Pop Clip", 400, 400);

            SplashKit.SetClip(200, 200, 200, 200);
            SplashKit.FillRectangle(Color.Red, 200, 200, 100, 100);

            SplashKit.PopClip();
            SplashKit.FillRectangle(Color.Green, 100, 150, 100, 100);

            SplashKit.RefreshScreen();
            SplashKit.Delay(5000);
        }
    }
}
