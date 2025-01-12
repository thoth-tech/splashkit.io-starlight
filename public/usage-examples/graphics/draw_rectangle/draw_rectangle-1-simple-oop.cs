using SplashKitSDK;

namespace DrawRactangleExample
{
    public class Program
    {
        public static void Main()
        {
            Window window = new Window("Draw Rectangle", 800, 600);
            window.Clear(Color.White);

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

            window.Refresh();
            SplashKit.Delay(4000);
            window.Close();
        }
    }
}



