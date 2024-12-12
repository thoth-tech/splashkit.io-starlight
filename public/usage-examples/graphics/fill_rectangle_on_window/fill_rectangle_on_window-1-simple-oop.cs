using SplashKitSDK;

namespace Program
{
  public class Program
  {
    public static void Main()
    {
      Window myWindow = SplashKit.OpenWindow("Fill Rectangle On Window", 800, 600);

      // Fill rectangle on the window and refresh
      SplashKit.FillRectangleOnWindow(myWindow, SplashKit.ColorBlue(), 300, 250, 200, 100);
      SplashKit.RefreshWindow(myWindow);

      SplashKit.Delay(3000);
      SplashKit.CloseWindow(myWindow);
    }
  }
}
