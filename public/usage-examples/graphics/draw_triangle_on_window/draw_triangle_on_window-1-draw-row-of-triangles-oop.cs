using SplashKitSDK;

namespace DrawCircleOnWindow
{
    public class Program
    {
        public static void Main()
        {
        Window myWindow = SplashKit.OpenWindow("Draw Triangle on Window", 800, 600);
        SplashKit.ClearScreen();

        for (int i = 0; i < 20; i++)
        {   
            // Set the x position for triangles increase by 40 * i every round
            double x = 40 * i;

            Color randomColor = SplashKit.RGBColor(
                SplashKit.Rnd(255), SplashKit.Rnd(255), SplashKit.Rnd(255)  
            );

            // Draw the triangles by increasing x position
            SplashKit.DrawTriangleOnWindow(myWindow, randomColor, 0 + x, 0, 20 + x, 40, 40 + x, 0);
        }

        SplashKit.RefreshScreen();
        SplashKit.Delay(4000);
        SplashKit.CloseAllWindows();
        }
    }
}

