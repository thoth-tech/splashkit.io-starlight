using static SplashKitSDK.SplashKit;
using SplashKitSDK;

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
            WriteLine(VectorToString(myVector1));
            WriteLine(VectorToString(myVector2));
            WriteLine(VectorToString(myVector3));
        }
    }
}
