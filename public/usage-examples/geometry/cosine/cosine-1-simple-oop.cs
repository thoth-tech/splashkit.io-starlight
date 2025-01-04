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
      float result = SplashKit.Cosine(input);

      // Write cosine to console
      SplashKit.Write("Cosine: ");
      SplashKit.WriteLine(result);
    }
  }
}