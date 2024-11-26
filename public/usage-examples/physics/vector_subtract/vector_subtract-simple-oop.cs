using SplashKitSDK;

namespace VectorSubtractionDemo
{
    public class Program
    {
        public static void Main()
        {
            // Define the first vector
            Vector2D myVector1 = new Vector2D() { X = 200, Y = 100 };

            // Define the second vector
            Vector2D myVector2 = new Vector2D() { X = -300, Y = 150 };

            // Subtract the vectors
            Vector2D resultVector = SplashKit.VectorSubtract(myVector1, myVector2);

            // Output the original vectors and the result
            SplashKit.WriteLine("First Vector: " + SplashKit.VectorToString(myVector1));
            SplashKit.WriteLine("Second Vector: " + SplashKit.VectorToString(myVector2));
            SplashKit.WriteLine("Result of Subtraction (Vector 1 - Vector 2): " + SplashKit.VectorToString(resultVector));
        }
    }
}
