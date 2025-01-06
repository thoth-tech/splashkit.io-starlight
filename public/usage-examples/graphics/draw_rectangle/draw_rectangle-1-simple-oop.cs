using SplashKitSDK;

namespace DrawRactangle
{
    public class Program
    {
        public static void Main()
        {
            SplashKit.OpenWindow("Draw Rectangle", 800, 600);
            SplashKit.ClearScreen();

            for (int i = 0; i < 21; i++)
            {   
                // Increase x position by 40 every round
                int x = i * 40 - 40;

                // Decrease y position by 30 every round
                int y = 600 - i * 30;

                Color randomColor = SplashKit.RGBColor(
                    SplashKit.Rnd(255), SplashKit.Rnd(255), SplashKit.Rnd(255)
                );

                // Draw rectangle base on the x, y position with width 40 and height 30
                SplashKit.DrawRectangle(randomColor, x, y, 40, 30);
            }

            SplashKit.RefreshScreen();
            SplashKit.Delay(4000);
            SplashKit.CloseAllWindows();
        }
    }
}



