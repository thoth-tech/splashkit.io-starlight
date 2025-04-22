using SplashKitSDK;

public class FillEllipseExample
{
    public static void Main()
    {
        FillEllipseExample example = new FillEllipseExample();
        example.Run();
    }

    public void Run()
    {
        SplashKit.OpenWindow("Fill Ellipse Example", 800, 600);

        SplashKit.ClearScreen(Color.White);

        SplashKit.FillEllipse(Color.Blue, 200, 200, 400, 200);
        SplashKit.DrawRectangle(Color.Red, 200, 200, 400, 200);

        SplashKit.RefreshScreen();

        SplashKit.Delay(4000);
        SplashKit.CloseAllWindows();
    }
}
