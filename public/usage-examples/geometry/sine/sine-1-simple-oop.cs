using SplashKitSDK;

namespace Program
{
  public class Program
  {
    public static void Main()
    {
      SplashKit.Write("Enter an angle: ");

      // User inputs angle
      float input = float.Parse(SplashKit.ReadLine());
      float result = SplashKit.Sine(input);

      // Write sine to console
      SplashKit.Write("Sine: ");
      SplashKit.WriteLine(result);
    }
  }
}