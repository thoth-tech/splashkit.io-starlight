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
            double myVector1Magnitude = SplashKit.VectorMagnitude(myVector1);

            // Output the vector and its magnitude
            SplashKit.WriteLine(SplashKit.VectorToString(myVector1));
            SplashKit.WriteLine("Vector Magnitude: " + myVector1Magnitude.ToString());
        }
    }
}
