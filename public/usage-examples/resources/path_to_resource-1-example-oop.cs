using SplashKitSDK;

namespace PathToResourceExample
{
    public class Program
    {
        public static void Main()
        {
            string resourcePath = SplashKit.PathToResource(
                "example.png",
                ResourceKind.ImageResource
            );

            SplashKit.WriteLine(
                "Image resource path: " + resourcePath
            );
        }
    }
}