using SplashKitSDK; // importing SplashKit library

namespace RayCircleIntersectDistanceExample // naming the example properly
{
    public class Program // main class of the program
    {
        public static void Main() // starting point of the program
        {
            // here I am creating a ray starting from (100,100)
            Point2D rayOrigin = SplashKit.PointAt(100, 100);

            // this is the direction of the ray, going to the right side
            Vector2D rayHeading = SplashKit.VectorFrom(1, 0);

            // here I am creating a circle at (250,100) with radius 50
            Circle targetCircle = SplashKit.CircleAt(250, 100, 50);

            // this function checks how far the ray travels before touching the circle
            double hitDistance = SplashKit.RayCircleIntersectDistance(rayOrigin, rayHeading, targetCircle);

            // printing the result so we can see what distance we get
            SplashKit.Write("Ray hit distance: ");
            SplashKit.WriteLine(hitDistance);
        }
    }
}