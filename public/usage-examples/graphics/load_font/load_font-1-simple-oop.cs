using SplashKitSDK;

namespace Program
{
  public class Program
  {
    public static void Main()
    {
      SplashKit.OpenWindow("Font Load Example", 800, 600);

      // Import font and draw text
      Font myFont = SplashKit.LoadFont("MyFont", "RobotoSlab.ttf");
      SplashKit.DrawText("Hello, SplashKit!", SplashKit.ColorBlack(), myFont, 40, 250, 270);
      SplashKit.RefreshScreen();

      SplashKit.Delay(10000);
      SplashKit.CloseAllWindows();
    }
  }
}