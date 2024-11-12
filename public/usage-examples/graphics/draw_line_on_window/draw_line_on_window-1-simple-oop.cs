using SplashKitSDK;

namespace draw_line_on_window
{
    public class Program
    {
        public static void Main()
        {
            // Create Window
            Window start = new Window("draw line on window", 600, 600);
            SplashKit.ClearScreen(SplashKit.ColorBlack());


            // Draw line on window - param (Window, Color, x1, y1, x2, y2)
            SplashKit.DrawLineOnWindow(start, SplashKit.ColorYellow(), 0,0,600,600);
            SplashKit.DrawLineOnWindow(start, SplashKit.ColorGreen(), 0,150,600,450);
            SplashKit.DrawLineOnWindow(start, SplashKit.ColorTeal(), 0,300,600,300);
            SplashKit.DrawLineOnWindow(start, SplashKit.ColorBlue(), 0,450,600,150);
            SplashKit.DrawLineOnWindow(start, SplashKit.ColorViolet(), 0,600,600,0);
            SplashKit.DrawLineOnWindow(start, SplashKit.ColorPurple(), 150,0,450,600);
            SplashKit.DrawLineOnWindow(start, SplashKit.ColorPink(), 300,0,300,600);
            SplashKit.DrawLineOnWindow(start, SplashKit.ColorRed(), 450,0,150,600);      
            SplashKit.DrawLineOnWindow(start, SplashKit.ColorOrange(), 600,0,0,600);

            SplashKit.RefreshScreen();
            SplashKit.Delay(5000);
            SplashKit.CloseAllWindows();
        }
    }
}
