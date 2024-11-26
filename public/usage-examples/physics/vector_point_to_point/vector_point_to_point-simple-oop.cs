using SplashKitSDK;

namespace VectorPointToPointDemo
{
    public class Program
    {
        public static void Main()
        {
            // Define the start and end points
            Point2D startPoint = new Point2D() { X = 200, Y = 100 };
            Point2D endPoint = new Point2D() { X = -300, Y = 150 };

            // Calculate the vector from start point to end point
            Vector2D myVector1 = SplashKit.VectorPointToPoint(startPoint, endPoint);

            // Output the vector
            SplashKit.WriteLine(SplashKit.VectorToString(myVector1));
        }
    }
}
