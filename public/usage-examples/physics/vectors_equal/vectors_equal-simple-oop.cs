using SplashKitSDK;
using static SplashKitSDK.SplashKit;

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
            WriteLine("Vector 1: " + VectorToString(myVector1));
            WriteLine("Vector 2: " + VectorToString(myVector2));
            WriteLine("Vector 3: " + VectorToString(myVector3));

            // Check if vectors are equal
            if (VectorsEqual(myVector1, myVector2))
                WriteLine("Vectors 1 and 2 are equal.");
            else
                WriteLine("Vectors 1 and 2 are not equal.");

            if (VectorsEqual(myVector1, myVector3))
                WriteLine("Vectors 1 and 3 are equal.");
            else
                WriteLine("Vectors 1 and 3 are not equal.");

            if (VectorsEqual(myVector2, myVector3))
                WriteLine("Vectors 2 and 3 are equal.");
            else
                WriteLine("Vectors 2 and 3 are not equal.");
        }
    }
}
