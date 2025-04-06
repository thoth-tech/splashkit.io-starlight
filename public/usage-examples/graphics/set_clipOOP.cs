using SplashKitSDK;

public class HouseClipDemo
{
    public void Run()
    {
        Window window = new Window("House Drawing with Clipping", 800, 600);

        Rectangle clipRect = SplashKit.RectangleFrom(250, 200, 300, 300);
        SplashKit.SetClip(clipRect);

        SplashKit.ClearScreen(Color.DarkOrange);

        SplashKit.FillRectangle(Color.Beige, 300, 250, 200, 200);

        SplashKit.DrawLine(Color.Brown, 300, 250, 400, 150);
        SplashKit.DrawLine(Color.Brown, 400, 150, 500, 250);
        SplashKit.DrawLine(Color.Brown, 300, 250, 500, 250);

        SplashKit.FillRectangle(Color.DarkRed, 375, 370, 50, 80);

        SplashKit.FillRectangle(Color.LightBlue, 320, 270, 40, 40);
        SplashKit.FillRectangle(Color.LightBlue, 440, 270, 40, 40);

        SplashKit.DrawRectangle(Color.Black, clipRect);

        SplashKit.RefreshScreen();
        SplashKit.Delay(5000);
    }

    public static void Main()
    {
        new HouseClipDemo().Run();
    }
}
