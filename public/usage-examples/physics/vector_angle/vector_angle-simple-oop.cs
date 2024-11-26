using SplashKitSDK;

namespace VectorAngleDemo
{
    public class Program
    {
        public static void Main()
        {
            // Define the vector
            Vector2D myVector1 = new Vector2D() { X = 200, Y = 100 };

            // Calculate the angle of the vector
            double myVector1Angle = SplashKit.VectorAngle(myVector1);

            // Output the results
            SplashKit.WriteLine("Vector 1: " + SplashKit.VectorToString(myVector1));
            SplashKit.WriteLine("Vector Angle: " + myVector1Angle);
        }
    }
}