using SplashKitSDK;

namespace VectorAngleDemo
{
    public class Program
    {
        public static void Main()
        {
            // Define the first vector
            Vector2D myVector1 = new Vector2D() { X = 200, Y = 100 };

            // Define the second vector
            Vector2D myVector2 = new Vector2D() { X = -300, Y = 150 };

            // Calculate the angle between the two vectors
            double vectorAngle = SplashKit.AngleBetween(myVector1, myVector2);

            // Output the vectors and the angle
            SplashKit.WriteLine(SplashKit.VectorToString(myVector1));
            SplashKit.WriteLine(SplashKit.VectorToString(myVector2));
            SplashKit.WriteLine(vectorAngle.ToString());
        }
    }
}
