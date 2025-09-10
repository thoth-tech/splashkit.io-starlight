using SplashKitSDK;

namespace VectorDetailsDemo
{
    public class Program
    {
        public static void Main()
        {
            // Define a vector
            Vector2D myVector = new Vector2D() { X = 200, Y = 100 };

            // Output the details of the vector
            SplashKit.WriteLine("Vector Details:");
            SplashKit.WriteLine("X: " + myVector.X);
            SplashKit.WriteLine("Y: " + myVector.Y);
            SplashKit.WriteLine("Vector as String: " + SplashKit.VectorToString(myVector));
        }
    }
}
