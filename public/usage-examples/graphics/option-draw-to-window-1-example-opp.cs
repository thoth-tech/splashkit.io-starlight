using SplashKitSDK;
using static SplashKitSDK.SplashKit;

public class BubblesProgram
{
    public static void Main()
    {
        window win = OpenWindow("Bubbles", 800, 600);
        ClearScreen(Color.White);

        for (int i = 0; i < 50; i++)
        {
            double x = Rnd(800);
            double y = Rnd(600);
            double radius = Rnd(10, 50);
            Color randomColor = RGBColor(Rnd(255), Rnd(255), Rnd(255));
            DrawCircle(randomColor, x, y, radius, OptionDrawTo(win));
        }

        RefreshWindow(win);
        Delay(4000);
        CloseAllWindows();
    }
}
