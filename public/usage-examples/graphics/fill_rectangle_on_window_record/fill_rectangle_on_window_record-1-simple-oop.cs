using SplashKitSDK;

namespace Program
{
  public class Program
  {
    public static void Main()
    {
      Window myWindow = SplashKit.OpenWindow("Fill Rectangle On Window", 800, 600);

      // Define a rectangle to draw
      Rectangle rect = SplashKit.RectangleFrom(300, 250, 200, 100); // x, y, width, height

      // Fill rectangle on the window and refresh
      SplashKit.FillRectangleOnWindow(myWindow, SplashKit.ColorBlue(), rect);
      SplashKit.RefreshWindow(myWindow);

      SplashKit.Delay(3000);
      SplashKit.CloseWindow(myWindow);
    }
  }
}
