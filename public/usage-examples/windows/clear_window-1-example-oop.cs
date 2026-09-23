using SplashKitSDK;

namespace ClearWindowExample
{
    public class Program
    {
        public static void Main()
        {
            // open a window
            Window wind = SplashKit.OpenWindow("Colour Changer", 600, 200);

            // main loop
            while (!SplashKit.QuitRequested())
            {
                // get user events
                SplashKit.ProcessEvents();

                // clear screen
                SplashKit.ClearWindow(wind, Color.White);

                if (SplashKit.Button("Red!", SplashKit.RectangleFrom(75, 85, 100, 30)))
                {
                    SplashKit.ClearWindow(wind, Color.Red);
                    SplashKit.RefreshWindow(wind);
                    SplashKit.Delay(1000);
                    continue;
                }

                if (SplashKit.Button("Green!", SplashKit.RectangleFrom(250, 85, 100, 30)))
                {
                    SplashKit.ClearWindow(wind, Color.Green);
                    SplashKit.RefreshWindow(wind);
                    SplashKit.Delay(1000);
                    continue;
                }

                if (SplashKit.Button("Blue!", SplashKit.RectangleFrom(425, 85, 100, 30)))
                {
                    SplashKit.ClearWindow(wind, Color.Blue);
                    SplashKit.RefreshWindow(wind);
                    SplashKit.Delay(1000);
                    continue;
                }
                // finally draw interface, then refresh window
                SplashKit.DrawInterface();
                SplashKit.RefreshWindow(wind);
            }

            // close all open windows
            SplashKit.CloseAllWindows();
        }
    }
}