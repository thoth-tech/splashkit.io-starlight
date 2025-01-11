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
            Vector2D myVector1Inverted = SplashKit.VectorInvert(myVector1);

            // Output the original and inverted vectors
            SplashKit.WriteLine(SplashKit.VectorToString(myVector1));
            SplashKit.WriteLine(SplashKit.VectorToString(myVector1Inverted));
        }
    }
}
