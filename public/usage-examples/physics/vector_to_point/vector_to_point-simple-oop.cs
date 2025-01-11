using SplashKitSDK;

namespace VectorToDemo
{
    public class Program
    {
        public static void Main()
        {
            // Define a point
            Point2D myPoint1 = new Point2D() { X = 200, Y = 100 };

            // Create a vector pointing to the point
            Vector2D myVector1 = SplashKit.VectorTo(myPoint1);

            // Output the vector
            SplashKit.WriteLine("my_vector_1 values: " + SplashKit.VectorToString(myVector1));
        }
    }
}
