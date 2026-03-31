using SplashKitSDK;
using static SplashKitSDK.SplashKit;
using System;

// Window dimensions
const int windowWidth = 800;
const int windowHeight = 600;

// Open a window for the lantern scene
OpenWindow("The Raycast Lantern", windowWidth, windowHeight);

// Max ray distance based on window diagonal for scalability
double maxRayDist = Math.Sqrt(windowWidth * windowWidth + windowHeight * windowHeight);

// Define obstacle rectangles (walls that block light)
Rectangle obstacle1 = RectangleFrom(150, 150, 100, 200);
Rectangle obstacle2 = RectangleFrom(500, 100, 150, 120);
Rectangle obstacle3 = RectangleFrom(350, 350, 200, 80);

// Define edges of each obstacle as lines for ray intersection
// Obstacle 1 edges
Line obs1Top = LineFrom(150, 150, 250, 150);
Line obs1Bottom = LineFrom(150, 350, 250, 350);
Line obs1Left = LineFrom(150, 150, 150, 350);
Line obs1Right = LineFrom(250, 150, 250, 350);

// Obstacle 2 edges
Line obs2Top = LineFrom(500, 100, 650, 100);
Line obs2Bottom = LineFrom(500, 220, 650, 220);
Line obs2Left = LineFrom(500, 100, 500, 220);
Line obs2Right = LineFrom(650, 100, 650, 220);

// Obstacle 3 edges
Line obs3Top = LineFrom(350, 350, 550, 350);
Line obs3Bottom = LineFrom(350, 430, 550, 430);
Line obs3Left = LineFrom(350, 350, 350, 430);
Line obs3Right = LineFrom(550, 350, 550, 430);

// Collect all edges into an array for easy iteration
const int numEdges = 12;
Line[] edges = {
    obs1Top, obs1Bottom, obs1Left, obs1Right,
    obs2Top, obs2Bottom, obs2Left, obs2Right,
    obs3Top, obs3Bottom, obs3Left, obs3Right
};

// Number of rays to cast around the lantern
const int numRays = 360;

while (!QuitRequested())
{
    ProcessEvents();

    // Lantern follows the mouse position
    Point2D lanternPos = MousePosition();

    // Store the endpoint of each ray (intersection or window edge)
    Point2D[] rayEndpoints = new Point2D[numRays];

    // Cast rays in all directions from the lantern
    for (int i = 0; i < numRays; i++)
    {
        double angle = i * (360.0 / numRays);

        // Create a direction vector for this ray
        Vector2D heading = VectorFromAngle(angle, 1.0);

        // Max ray distance based on window diagonal for scalability
        double closestDist = maxRayDist;
        Point2D closestPt = PointAt(
            lanternPos.X + heading.X * closestDist,
            lanternPos.Y + heading.Y * closestDist
        );

        // Check each obstacle edge for intersection
        for (int j = 0; j < numEdges; j++)
        {
            Point2D hitPt = PointAt(0, 0);

            // Use ray_intersection_point to detect where the ray hits an edge
            if (RayIntersectionPoint(lanternPos, heading, edges[j], ref hitPt))
            {
                // Calculate distance to this intersection
                double dist = PointPointDistance(lanternPos, hitPt);

                // Keep the closest intersection point
                if (dist < closestDist)
                {
                    closestDist = dist;
                    closestPt = hitPt;
                }
            }
        }

        rayEndpoints[i] = closestPt;
    }

    // Render the scene
    ClearScreen(ColorBlack());

    // Draw the illuminated area using filled triangles
    // Each triangle connects the lantern to two adjacent ray endpoints
    for (int i = 0; i < numRays; i++)
    {
        int next = (i + 1) % numRays;

        // Fill triangle to create the lit region
        FillTriangle(
            RGBAColor(255, 220, 100, 40),
            lanternPos.X, lanternPos.Y,
            rayEndpoints[i].X, rayEndpoints[i].Y,
            rayEndpoints[next].X, rayEndpoints[next].Y
        );

        // Draw triangle outline for subtle light boundary
        DrawTriangle(
            RGBAColor(255, 220, 100, 15),
            lanternPos.X, lanternPos.Y,
            rayEndpoints[i].X, rayEndpoints[i].Y,
            rayEndpoints[next].X, rayEndpoints[next].Y
        );
    }

    // Draw light rays from lantern to intersection points
    for (int i = 0; i < numRays; i += 6)
    {
        DrawLine(RGBAColor(255, 200, 50, 20), lanternPos, rayEndpoints[i]);
    }

    // Draw the obstacle outlines on top
    DrawRectangle(ColorDarkGray(), obstacle1);
    DrawRectangle(ColorDarkGray(), obstacle2);
    DrawRectangle(ColorDarkGray(), obstacle3);

    // Fill obstacles to make them look solid
    FillRectangle(ColorGray(), obstacle1);
    FillRectangle(ColorGray(), obstacle2);
    FillRectangle(ColorGray(), obstacle3);

    // Draw the lantern glow at the mouse position
    FillCircle(ColorYellow(), lanternPos.X, lanternPos.Y, 8);
    FillCircle(RGBAColor(255, 200, 50, 100), lanternPos.X, lanternPos.Y, 20);

    // Display instructions
    DrawText("Move the mouse to reposition the lantern", ColorWhite(), 10, 10);
    DrawText("Rays: " + numRays + " | Obstacles: 3", ColorWhite(), 10, 30);

    RefreshScreen(60);
}

CloseAllWindows();
