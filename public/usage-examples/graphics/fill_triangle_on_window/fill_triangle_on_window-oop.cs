using SplashKitSDK;

namespace Program
{
    public class Program
    {
        public static void Main()
        {
        SplashKit.OpenWindow("Fill Triangle on Window", 800, 600);
        

        Random random = new Random();
        for (int i = 0; i < 50; i++)
        {
            int x1 = random.Next(800);
            int y1 = random.Next(600);
            int x2 = random.Next(800);
            int y2 = random.Next(600);
            int x3 = random.Next(800);
            int y3 = random.Next(600);
            
            Color randomColor = SplashKit.RGBColor(
                SplashKit.Rnd(255), SplashKit.Rnd(255), SplashKit.Rnd(255)
            );

            SplashKit.FillTriangle(randomColor, x1, y1, x2, y2, x3, y3);
        }

        SplashKit.RefreshScreen();
        SplashKit.Delay(4000);

        SplashKit.CloseAllWindows();
        }
    }
}
