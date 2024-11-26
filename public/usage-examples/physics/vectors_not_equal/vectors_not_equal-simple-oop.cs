using SplashKitSDK;

namespace VectorComparisonDemo
{
    public class Program
    {
        public static void Main()
        {
            // Define the first vector
            Vector2D myVector1 = new Vector2D() { X = 200, Y = 100 };

            // Define the second vector
            Vector2D myVector2 = new Vector2D() { X = -300, Y = 150 };

            // Define the third vector
            Vector2D myVector3 = new Vector2D() { X = 200, Y = 100 };

            // Print the vectors
            SplashKit.WriteLine("Vector 1: " + SplashKit.VectorToString(myVector1));
            SplashKit.WriteLine("Vector 2: " + SplashKit.VectorToString(myVector2));
            SplashKit.WriteLine("Vector 3: " + SplashKit.VectorToString(myVector3));

            // Check if vectors are not equal
            if (SplashKit.VectorsNotEqual(myVector1, myVector2))
                SplashKit.WriteLine("Vectors 1 and 2 are not equal.");
            else
                SplashKit.WriteLine("Vectors 1 and 2 are equal.");

            if (SplashKit.VectorsNotEqual(myVector1, myVector3))
                SplashKit.WriteLine("Vectors 1 and 3 are not equal.");
            else
                SplashKit.WriteLine("Vectors 1 and 3 are equal.");

            if (SplashKit.VectorsNotEqual(myVector2, myVector3))
                SplashKit.WriteLine("Vectors 2 and 3 are not equal.");
            else
                SplashKit.WriteLine("Vectors 2 and 3 are equal.");
        }
    }
}
