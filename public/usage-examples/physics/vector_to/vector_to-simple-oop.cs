using SplashKitSDK;

namespace VectorToDemo
{
    public class Program
    {
        public static void Main()
        {
            // Create a vector pointing to the specified coordinates
            Vector2D myVector1 = SplashKit.VectorTo(200, 100);

            // Output the vector
            SplashKit.WriteLine("my_vector_1 values: " + SplashKit.VectorToString(myVector1));
        }
    }
}
