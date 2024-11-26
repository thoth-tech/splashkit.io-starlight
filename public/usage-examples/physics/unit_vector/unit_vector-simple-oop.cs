using SplashKitSDK;

namespace VectorUnitDemo
{
    public class Program
    {
        public static void Main()
        {
            // Define the vector
            Vector2D myVector1 = new Vector2D() { X = 200, Y = 100 };

            // Compute the unit vector
            Vector2D myUnitVector1 = SplashKit.UnitVector(myVector1);

            // Output the original vector and its magnitude
            SplashKit.WriteLine("Original Vector: " + SplashKit.VectorToString(myVector1));
            SplashKit.WriteLine("Original Vector Magnitude: " + SplashKit.VectorMagnitude(myVector1));

            // Output the unit vector and its magnitude
            SplashKit.WriteLine("Unit Vector: " + SplashKit.VectorToString(myUnitVector1));
            SplashKit.WriteLine("Unit Vector Magnitude: " + SplashKit.VectorMagnitude(myUnitVector1));
        }
    }
}
