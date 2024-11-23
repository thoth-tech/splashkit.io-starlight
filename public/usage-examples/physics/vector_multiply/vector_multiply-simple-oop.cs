using static SplashKitSDK.SplashKit;
using SplashKitSDK;

namespace VectorMultiplicationDemo
{
    public class Program
    {
        public static void Main()
        {
            // Define the vector
            Vector2D myVector1 = new Vector2D() { X = 200, Y = 100 };

            // Multiply the vector by a scalar
            Vector2D myVector1Multiplied = VectorMultiply(myVector1, 5);

            // Output the original and multiplied vectors
            WriteLine(VectorToString(myVector1));
            WriteLine(VectorToString(myVector1Multiplied));
        }
    }
}
