using SplashKitSDK;

namespace DotProductExample
{
    public class Program
    {
        public static void Main()
        {
            // Define the first vector
            Vector2D myVector1 = new Vector2D() { X = 200, Y = 100 };

            // Define the second vector
            Vector2D myVector2 = new Vector2D() { X = -300, Y = 150 };

            // Calculate the dot product
            double vectorDotProduct = SplashKit.DotProduct(myVector1, myVector2);

            // Output vector details and the dot product
            SplashKit.WriteLine(SplashKit.VectorToString(myVector1));
            SplashKit.WriteLine(SplashKit.VectorToString(myVector2));
            SplashKit.WriteLine($"Dot Product of Vectors: {vectorDotProduct}");
        }
    }
}
