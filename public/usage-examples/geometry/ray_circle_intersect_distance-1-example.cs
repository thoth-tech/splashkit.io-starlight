using SplashKitSDK;
using static SplashKitSDK.SplashKit;

// set up a ray pointing to the right so the result is easy to predict and verify
Point2D rayOrigin = PointAt(100, 100);
Vector2D rayHeading = VectorTo(1, 0);

// place the circle directly in the path of the ray so an intersection will happen
Circle targetCircle = CircleAt(250, 100, 50);

// calculate how far the ray travels before it first touches the circle
double hitDistance = RayCircleIntersectDistance(rayOrigin, rayHeading, targetCircle);

// print the result so we can clearly see and check the returned distance
Write("Ray hit distance: ");
WriteLine(hitDistance);
