using SplashKitSDK;

namespace FillRectangle
{
    public class Program
    {
        public static void Main()
        {   
            //Create a window with title Fill rectangle, width 800, height 600.
            SplashKit.OpenWindow("Fill Rectangle", 800, 600);
            SplashKit.ClearScreen();

            //draw three rectangles with color green, yellow, and red with different position as (100,200), (300,200), (500,200) with same size.
            SplashKit.FillRectangle(SplashKit.ColorGreen(), 100, 200, 200, 100);
            SplashKit.FillRectangle(SplashKit.ColorYellow(), 300, 200, 200, 100);
            SplashKit.FillRectangle(SplashKit.ColorRed(), 500, 200, 200, 100);

            SplashKit.RefreshScreen();
            SplashKit.Delay(4000);
            SplashKit.CloseAllWindows();
        }    
    }
}

