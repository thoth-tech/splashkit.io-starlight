using static SplashKitSDK.SplashKit;
using SplashKitSDK;

namespace VectorToDemo
{
    public class Program
    {
        public static void Main()
        {
            // Create a vector pointing to the specified coordinates
            Vector2D myVector1 = VectorTo(200, 100);

            // Output the vector
            WriteLine("my_vector_1 values: " + VectorToString(myVector1));
        }
    }
}
