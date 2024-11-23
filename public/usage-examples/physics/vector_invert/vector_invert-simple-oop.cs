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

            // Invert the vector
            Vector2D myVector1Inverted = VectorInvert(myVector1);

            // Output the original and inverted vectors
            WriteLine(VectorToString(myVector1));
            WriteLine(VectorToString(myVector1Inverted));
        }
    }
}
