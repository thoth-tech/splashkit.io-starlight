using SplashKitSDK;

namespace FillCircleOnWindow
{
    public class Program
    {
        public static void Main()
        {
            // Open a new window and initialize to a window variable wnd1
            Window wnd1 = SplashKit.OpenWindow("Traffic Lights", 800, 600);
            SplashKit.ClearScreen();

            // Use function to place 3 circles in destination window (wnd1) as traffic lights
            SplashKit.FillCircleOnWindow(wnd1, Color.Red, 400, 100, 50);
            SplashKit.FillCircleOnWindow(wnd1, Color.Yellow, 400, 250, 50);
            SplashKit.FillCircleOnWindow(wnd1, Color.Green, 400, 400, 50);

            SplashKit.RefreshScreen();
            SplashKit.Delay(5000);
   
            //Close loaded windows   
            SplashKit.CloseAllWindows();

        }
    }
}