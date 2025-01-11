using SplashKitSDK;

namespace Program
{
  public class Program
  {
    public static void Main()
    {
      Window myWindow = SplashKit.OpenWindow("Draw Snowman On Window", 800, 600);

      // Draw snowman to window and refresh
      SplashKit.ClearScreen(SplashKit.ColorLightBlue());
      SplashKit.FillEllipseOnWindow(myWindow, SplashKit.ColorWhite(), 300, 400, 200, 200);
      SplashKit.FillEllipseOnWindow(myWindow, SplashKit.ColorWhite(), 320, 240, 160, 160);
      SplashKit.FillEllipseOnWindow(myWindow, SplashKit.ColorBlack(), 350, 300, 10, 10);
      SplashKit.FillEllipseOnWindow(myWindow, SplashKit.ColorBlack(), 400, 300, 10, 10);
      SplashKit.FillTriangleOnWindow(myWindow, SplashKit.ColorOrange(), 325, 330, 375, 320, 375, 340);
      SplashKit.RefreshWindow(myWindow);

      SplashKit.Delay(6000);
      SplashKit.CloseWindow(myWindow);
    }
  }
}