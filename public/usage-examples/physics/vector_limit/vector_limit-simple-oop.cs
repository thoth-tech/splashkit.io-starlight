using SplashKitSDK;

namespace VectorOperations
{
    public class Program
    {
        public static void Main()
        {
            // Define a vector
            Vector2D myVector1 = new Vector2D { X = 200, Y = 100 };

            // Limit the vector magnitude to 10
            Vector2D myVector1Limited = SplashKit.VectorLimit(myVector1, 10);

            // Output the original and limited vectors
            SplashKit.WriteLine(SplashKit.VectorToString(myVector1));
            SplashKit.WriteLine(SplashKit.VectorToString(myVector1Limited));
        }
    }
}
