using static SplashKitSDK.SplashKit;
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
            Vector2D myUnitVector1 = UnitVector(myVector1);

            // Output the original vector and its magnitude
            WriteLine("Original Vector: " + VectorToString(myVector1));
            WriteLine("Original Vector Magnitude: " + VectorMagnitude(myVector1));

            // Output the unit vector and its magnitude
            WriteLine("Unit Vector: " + VectorToString(myUnitVector1));
            WriteLine("Unit Vector Magnitude: " + VectorMagnitude(myUnitVector1));
        }
    }
}
