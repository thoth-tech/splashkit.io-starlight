using static SplashKitSDK.SplashKit;
using System;

// Create a ray from origin pointing right
Point2d rayOrigin = PointAt(0, 0);
Vector2d rayDirection = VectorTo(1, 0);

// Create a circle to test intersection
Point2d centerPoint = PointAt(50, 0);
Circle target = CircleAt(centerPoint, 25);

// Calculate distance to circle intersection
float distance = RayCircleIntersectDistance(rayOrigin, rayDirection, target);

Console.WriteLine($"Distance to circle: {distance}");
