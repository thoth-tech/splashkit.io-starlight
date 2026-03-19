using static SplashKitSDK.SplashKit; // this allows us to use SplashKit functions directly

// here I am creating a ray starting from (100,100)
Point2D rayOrigin = PointAt(100, 100);

// this is the direction of the ray, going to the right side
Vector2D rayHeading = VectorFrom(1, 0);

// here I am creating a circle at (250,100) with radius 50
Circle targetCircle = CircleAt(250, 100, 50);

// this function checks how far the ray travels before touching the circle
double hitDistance = RayCircleIntersectDistance(rayOrigin, rayHeading, targetCircle);

// printing the result so we can see what distance we get
Write("Ray hit distance: ");
WriteLine(hitDistance);