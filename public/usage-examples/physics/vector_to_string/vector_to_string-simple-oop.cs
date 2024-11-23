using SplashKitSDK;
using static SplashKitSDK.SplashKit;

namespace VectorDetailsDemo
{
    public class Program
    {
        public static void Main()
        {
            // Define a vector
            Vector2D myVector = new Vector2D() { X = 200, Y = 100 };

            // Output the details of the vector
            WriteLine("Vector Details:");
            WriteLine("X: " + myVector.X);
            WriteLine("Y: " + myVector.Y);
            WriteLine("Vector as String: " + VectorToString(myVector));
        }
    }
}
