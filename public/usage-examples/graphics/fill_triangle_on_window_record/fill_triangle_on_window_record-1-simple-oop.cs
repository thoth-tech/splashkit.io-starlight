using SplashKitSDK;

namespace Program
{
  public class Program
  {
    public static void Main()
    {
      Window myWindow = SplashKit.OpenWindow("Fill Triangle On Window", 800, 600);

      // Define a triangle to draw
      Triangle tri = SplashKit.TriangleFrom(300, 250, 500, 250, 400, 350);

      // Fill triangle on the window and refresh
      SplashKit.FillTriangleOnWindow(myWindow, SplashKit.ColorBlue(), tri);
      SplashKit.RefreshWindow(myWindow);

      SplashKit.Delay(3000);
      SplashKit.CloseWindow(myWindow);
    }
  }
}
