using SplashKitSDK;

namespace VectorScalingDemo
{
    public class Program
    {
        public static void Main()
        {
            // Define the vector
            Vector2D myVector1 = new Vector2D() { X = 200, Y = 100 };
            double vectorScale = 5;

            // Multiply the vector by a scalar value
            SplashKit.WriteLine("Multiply Vector by: " + vectorScale);
            Vector2D myVector1Multiplied = SplashKit.VectorMultiply(myVector1, vectorScale);

            // Output the original and multiplied vectors
            SplashKit.WriteLine("Original Vector: " + SplashKit.VectorToString(myVector1));
            SplashKit.WriteLine("Vector multiplied by scaling value: " + SplashKit.VectorToString(myVector1Multiplied));
        }
    }
}
