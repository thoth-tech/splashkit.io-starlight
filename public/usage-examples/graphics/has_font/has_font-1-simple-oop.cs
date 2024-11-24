using SplashKitSDK;

namespace Program
{
  public class Program
  {
    public static void Main()
    {
      Font myFont = null;

      // Check if program has font
      SplashKit.Write("Font available before loading: ");
      SplashKit.WriteLine(SplashKit.HasFont(myFont).ToString());

      // Load font
      myFont = SplashKit.LoadFont("MyFont", "RobotoSlab.ttf");

      // Check if program has font again
      SplashKit.Write("Font available after loading: ");
      SplashKit.WriteLine(SplashKit.HasFont(myFont).ToString());
    }
  }
}