using SplashKitSDK;
using static SplashKitSDK.SplashKit;

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
            Vector2D resultVector = VectorSubtract(myVector1, myVector2);

            // Output the original vectors and the result
            WriteLine("First Vector: " + VectorToString(myVector1));
            WriteLine("Second Vector: " + VectorToString(myVector2));
            WriteLine("Result of Subtraction (Vector 1 - Vector 2): " + VectorToString(resultVector));
        }
    }
}
