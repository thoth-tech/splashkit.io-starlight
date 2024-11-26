using SplashKitSDK;

namespace VectorNormalDemo
{
    public class Program
    {
        public static void Main()
        {
            // Define vectors
            Vector2D myVector1 = new Vector2D() { X = 200, Y = 100 };
            Vector2D myVector2 = new Vector2D() { X = 0, Y = 0 };

            // Calculate normals
            Vector2D myVector1Normal = SplashKit.VectorNormal(myVector1);
            Vector2D myVector2Normal = SplashKit.VectorNormal(myVector2);

            // Display results
            SplashKit.WriteLine("Original Vector: " + SplashKit.VectorToString(myVector1));
            SplashKit.WriteLine("Original Vector Magnitude: " + SplashKit.VectorMagnitude(myVector1));
            SplashKit.WriteLine("Vector Normal: " + SplashKit.VectorToString(myVector1Normal));
            SplashKit.WriteLine("Vector Normal Magnitude: " + SplashKit.VectorMagnitude(myVector1Normal));

            SplashKit.WriteLine("Null Vector: " + SplashKit.VectorToString(myVector2));
            SplashKit.WriteLine("Null Vector Magnitude: " + SplashKit.VectorMagnitude(myVector2));
            SplashKit.WriteLine("Null Vector Normal: " + SplashKit.VectorToString(myVector2Normal));
            SplashKit.WriteLine("Null Vector Normal Magnitude: " + SplashKit.VectorMagnitude(myVector2Normal));
        }
    }
}
