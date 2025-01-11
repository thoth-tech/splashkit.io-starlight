using SplashKitSDK;

namespace Program
{
  public class Program
  {
    public static void Main()
    {
      SplashKit.OpenWindow("Set Font Style", 800, 600);

      Font myFont = SplashKit.LoadFont("MyFont", "RobotoSlab.ttf");

      // Set font style to bold
      SplashKit.SetFontStyle(myFont, FontStyle.BoldFont);
      SplashKit.DrawText("Hello, SplashKit!", SplashKit.ColorBlack(), myFont, 40, 250, 270);
      SplashKit.RefreshScreen();

      SplashKit.Delay(5000);
      SplashKit.CloseAllWindows();
    }
  }
}