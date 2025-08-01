using SplashKitSDK;

public class Program
{
    public static void Main()
    {
        Window window = new Window("Draw Circle", 800, 600); // I am opening a window with size 800x600
        SplashKit.ClearScreen(Color.White);                  // I am clearing the screen with white
        SplashKit.DrawCircle(Color.Red, 400, 300, 100);      // I am drawing an outlined red circle at the center
        SplashKit.RefreshScreen();                           // I am displaying everything I drew
        SplashKit.Delay(3000);                               // I am waiting 3 seconds so I can see the result
        window.Close();                                      // I am closing the window when done
    }
}