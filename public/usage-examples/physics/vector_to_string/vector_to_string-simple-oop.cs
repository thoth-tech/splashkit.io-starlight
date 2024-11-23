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

            // Output the vector
            WriteLine(VectorToString(myVector1));
        }
    }
}
