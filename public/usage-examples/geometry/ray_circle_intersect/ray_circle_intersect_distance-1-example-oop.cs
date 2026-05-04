using SplashKitSDK;

namespace RayCircleIntersectDistanceExample
{
    public class Program
    {
        public static void Main()
        {
            // set up a ray pointing to the right so the result is easy to predict and verify
            Point2D rayOrigin = SplashKit.PointAt(100, 100);
            Vector2D rayHeading = SplashKit.VectorTo(1, 0);

            // place the circle directly in the path of the ray so an intersection will happen
            Circle targetCircle = SplashKit.CircleAt(250, 100, 50);

            // calculate how far the ray travels before it first touches the circle
            double hitDistance = SplashKit.RayCircleIntersectDistance(rayOrigin, rayHeading, targetCircle);

            // print the result so we can clearly see and check the returned distance
            SplashKit.Write("Ray hit distance: ");
            SplashKit.WriteLine(hitDistance);
        }
    }
}

