using static SplashKitSDK.SplashKit;
using SplashKitSDK;

namespace VectorOperations
{
    public class Program
    {
        public static void Main()
        {
            // Define a vector
            Vector2D myVector1 = new Vector2D { X = 200, Y = 100 };

            // Limit the vector magnitude to 10
            Vector2D myVector1Limited = VectorLimit(myVector1, 10);

            // Output the original and limited vectors
            WriteLine(VectorToString(myVector1));
            WriteLine(VectorToString(myVector1Limited));
        }
    }
}
