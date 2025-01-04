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
      float result = SplashKit.Tangent(input);

      // Write tangent to console
      SplashKit.Write("Tangent: ");
      SplashKit.WriteLine(result);
    }
  }
}