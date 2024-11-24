using SplashKitSDK;

namespace Program
{
  public class Program
  {
    public static void Main()
    {
      Window myWindow = SplashKit.OpenWindow("Draw Snowman On Window", 800, 600);

      // Define rectangles for each ellipse
      Rectangle body = SplashKit.RectangleFrom(300, 400, 200, 200);
      Rectangle head = SplashKit.RectangleFrom(320, 240, 160, 160);
      Rectangle leftEye = SplashKit.RectangleFrom(350, 300, 10, 10);
      Rectangle rightEye = SplashKit.RectangleFrom(400, 300, 10, 10);

      // Draw snowman to window and refresh
      SplashKit.ClearScreen(SplashKit.ColorLightBlue());
      SplashKit.FillEllipseOnWindow(myWindow, SplashKit.ColorWhite(), body);
      SplashKit.FillEllipseOnWindow(myWindow, SplashKit.ColorWhite(), head);
      SplashKit.FillEllipseOnWindow(myWindow, SplashKit.ColorBlack(), leftEye);
      SplashKit.FillEllipseOnWindow(myWindow, SplashKit.ColorBlack(), rightEye);
      SplashKit.FillTriangleOnWindow(myWindow, SplashKit.ColorOrange(), 325, 330, 375, 320, 375, 340);
      SplashKit.RefreshWindow(myWindow);

      SplashKit.Delay(6000);
      SplashKit.CloseWindow(myWindow);
    }
  }
}