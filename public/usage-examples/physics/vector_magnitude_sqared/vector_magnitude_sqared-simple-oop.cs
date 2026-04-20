using SplashKitSDK;

namespace VectorOperations
{
    public class Program
    {
        public static void Main()
        {
            // Define a vector
            Vector2D myVector1 = new Vector2D { X = 200, Y = 100 };

            // Calculate the squared magnitude of the vector
            double myVector1MagnitudeSquared = SplashKit.VectorMagnitudeSqared(myVector1);

            // Output the vector and its squared magnitude
            SplashKit.WriteLine(SplashKit.VectorToString(myVector1));
            SplashKit.WriteLine("Vector Magnitude Squared: " + myVector1MagnitudeSquared.ToString());
        }
    }
}
