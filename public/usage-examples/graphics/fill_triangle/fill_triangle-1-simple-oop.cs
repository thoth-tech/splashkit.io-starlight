using SplashKitSDK;

namespace Program
{
  public class Program
  {
    public static void Main()
    {
      Window myWindow = SplashKit.OpenWindow("Simple Red Triangle", 800, 600);
      SplashKit.FillTriangle(SplashKit.ColorRed(), 100, 100, 200, 200, 300, 100);
      SplashKit.RefreshWindow(myWindow);
      SplashKit.Delay(3000);
      SplashKit.CloseWindow(myWindow);
    }
  }
}