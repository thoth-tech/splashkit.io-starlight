using SplashKitSDK;
using static SplashKitSDK.SplashKit;

namespace VectorAdditionDemo
{
    public class Program
    {
        public static void Main()
        {
            // Define the first vector
            Vector2D myVector1 = new Vector2D() { X = 200, Y = 100 };

            // Define the second vector
            Vector2D myVector2 = new Vector2D() { X = -300, Y = 150 };

            // Add the vectors
            Vector2D myVector3 = VectorAdd(myVector1, myVector2);

            // Output vector details and the result
            WriteLine("Vector 1: " + VectorToString(myVector1));
            WriteLine("Vector 2: " + VectorToString(myVector2));
            WriteLine("Vector 1 + 2: " + VectorToString(myVector3));
        }
    }
}
