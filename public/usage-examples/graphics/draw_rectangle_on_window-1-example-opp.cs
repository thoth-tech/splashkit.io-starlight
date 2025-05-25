using SplashKitSDK;

public class Program
{
    public static void Main()
    {
        // Open two windows side by side
        Window redWindow = new Window("Red Rectangles", 400, 300);
        Window blueWindow = new Window("Blue Rectangles", 400, 300);
        SplashKit.MoveWindowTo(blueWindow, SplashKit.WindowX(redWindow) + SplashKit.WindowWidth(redWindow), SplashKit.WindowY(redWindow));

        // Clear both windows
        SplashKit.ClearWindow(redWindow, Color.White);
        SplashKit.ClearWindow(blueWindow, Color.White);

        // Draw red rectangles on the first window
        for (int i = 0; i < 5; i++)
        {
            SplashKit.FillRectangleOnWindow(redWindow, Color.Red, 30 + i * 60, 80, 40, 100);
        }

        // Draw blue rectangles on the second window
        for (int i = 0; i < 5; i++)
        {
            SplashKit.FillRectangleOnWindow(blueWindow, Color.Blue, 30 + i * 60, 80, 40, 100);
        }

        SplashKit.RefreshWindow(redWindow);
        SplashKit.RefreshWindow(blueWindow);

        SplashKit.Delay(4000);

        redWindow.Close();
        blueWindow.Close();
    }
}
