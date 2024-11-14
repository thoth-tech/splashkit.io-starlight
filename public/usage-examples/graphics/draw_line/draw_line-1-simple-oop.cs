using SplashKitSDK;

namespace draw_line_on_window
{
    public class Program
    {
        public static void Main()
        {
            // Create Window
            SplashKit.OpenWindow("Draw Line", 600, 600);
            SplashKit.ClearScreen(SplashKit.ColorBlack());


            // Draw line param (Color, x1, y1, x2, y2)
            SplashKit.DrawLine(SplashKit.ColorYellow(), 0,0,600,600);
            SplashKit.DrawLine(SplashKit.ColorGreen(), 0,150,600,450);
            SplashKit.DrawLine(SplashKit.ColorTeal(), 0,300,600,300);
            SplashKit.DrawLine(SplashKit.ColorBlue(), 0,450,600,150);
            SplashKit.DrawLine(SplashKit.ColorViolet(), 0,600,600,0);
            SplashKit.DrawLine(SplashKit.ColorPurple(), 150,0,450,600);
            SplashKit.DrawLine(SplashKit.ColorPink(), 300,0,300,600);
            SplashKit.DrawLine(SplashKit.ColorRed(), 450,0,150,600);      
            SplashKit.DrawLine(SplashKit.ColorOrange(), 600,0,0,600);

            SplashKit.RefreshScreen();
            SplashKit.Delay(5000);
            SplashKit.CloseAllWindows();
        }
    }
}
