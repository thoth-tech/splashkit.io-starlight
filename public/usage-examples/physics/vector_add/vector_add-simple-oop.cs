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
            Vector2D myVector3 = SplashKit.VectorAdd(myVector1, myVector2);

            // Output vector details and the result
            SplashKit.WriteLine("Vector 1: " + SplashKit.VectorToString(myVector1));
            SplashKit.WriteLine("Vector 2: " + SplashKit.VectorToString(myVector2));
            SplashKit.WriteLine("Vector 1 + 2: " + SplashKit.VectorToString(myVector3));
        }
    }
}
