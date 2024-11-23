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

            // Calculate the magnitude of the vector
            double myVector1Magnitude = VectorMagnitude(myVector1);

            // Output the vector and its magnitude
            WriteLine(VectorToString(myVector1));
            WriteLine(myVector1Magnitude.ToString());
        }
    }
}
