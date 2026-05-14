using SplashKitSDK;
using System;

namespace RayIntersectionPointExample
{
    public class Program
    {
        public static void Main()
        {
            // Window dimensions
            const int windowWidth = 800;
            const int windowHeight = 600;

            // Open a window for the lantern scene
            SplashKit.OpenWindow("The Raycast Lantern", windowWidth, windowHeight);

            // Max ray distance based on window diagonal for scalability
            double maxRayDist = Math.Sqrt(windowWidth * windowWidth + windowHeight * windowHeight);

            // Define obstacle rectangles (walls that block light)
            Rectangle obstacle1 = SplashKit.RectangleFrom(150, 150, 100, 200);
            Rectangle obstacle2 = SplashKit.RectangleFrom(500, 100, 150, 120);
            Rectangle obstacle3 = SplashKit.RectangleFrom(350, 350, 200, 80);

            // Define edges of each obstacle as lines for ray intersection
            // Obstacle 1 edges
            Line obs1Top = SplashKit.LineFrom(150, 150, 250, 150);
            Line obs1Bottom = SplashKit.LineFrom(150, 350, 250, 350);
            Line obs1Left = SplashKit.LineFrom(150, 150, 150, 350);
            Line obs1Right = SplashKit.LineFrom(250, 150, 250, 350);

            // Obstacle 2 edges
            Line obs2Top = SplashKit.LineFrom(500, 100, 650, 100);
            Line obs2Bottom = SplashKit.LineFrom(500, 220, 650, 220);
            Line obs2Left = SplashKit.LineFrom(500, 100, 500, 220);
            Line obs2Right = SplashKit.LineFrom(650, 100, 650, 220);

            // Obstacle 3 edges
            Line obs3Top = SplashKit.LineFrom(350, 350, 550, 350);
            Line obs3Bottom = SplashKit.LineFrom(350, 430, 550, 430);
            Line obs3Left = SplashKit.LineFrom(350, 350, 350, 430);
            Line obs3Right = SplashKit.LineFrom(550, 350, 550, 430);

            // Collect all edges into an array for easy iteration
            const int numEdges = 12;
            Line[] edges = {
                obs1Top, obs1Bottom, obs1Left, obs1Right,
                obs2Top, obs2Bottom, obs2Left, obs2Right,
                obs3Top, obs3Bottom, obs3Left, obs3Right
            };

            // Number of rays to cast around the lantern
            const int numRays = 360;

            while (!SplashKit.QuitRequested())
            {
                SplashKit.ProcessEvents();

                // Lantern follows the mouse position
                Point2D lanternPos = SplashKit.MousePosition();

                // Store the endpoint of each ray (intersection or window edge)
                Point2D[] rayEndpoints = new Point2D[numRays];

                // Cast rays in all directions from the lantern
                for (int i = 0; i < numRays; i++)
                {
                    double angle = i * (360.0 / numRays);

                    // Create a direction vector for this ray
                    Vector2D heading = SplashKit.VectorFromAngle(angle, 1.0);

                    // Max ray distance based on window diagonal for scalability
                    double closestDist = maxRayDist;
                    Point2D closestPt = SplashKit.PointAt(
                        lanternPos.X + heading.X * closestDist,
                        lanternPos.Y + heading.Y * closestDist
                    );

                    // Check each obstacle edge for intersection
                    for (int j = 0; j < numEdges; j++)
                    {
                        Point2D hitPt = SplashKit.PointAt(0, 0);

                        // Use ray_intersection_point to detect where the ray hits an edge
                        if (SplashKit.RayIntersectionPoint(lanternPos, heading, edges[j], ref hitPt))
                        {
                            // Calculate distance to this intersection
                            double dist = SplashKit.PointPointDistance(lanternPos, hitPt);

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
                SplashKit.ClearScreen(Color.Black);

                // Draw the illuminated area using filled triangles
                // Each triangle connects the lantern to two adjacent ray endpoints
                for (int i = 0; i < numRays; i++)
                {
                    int next = (i + 1) % numRays;

                    // Fill triangle to create the lit region
                    SplashKit.FillTriangle(
                        SplashKit.RGBAColor(255, 220, 100, 40),
                        lanternPos.X, lanternPos.Y,
                        rayEndpoints[i].X, rayEndpoints[i].Y,
                        rayEndpoints[next].X, rayEndpoints[next].Y
                    );

                    // Draw triangle outline for subtle light boundary
                    SplashKit.DrawTriangle(
                        SplashKit.RGBAColor(255, 220, 100, 15),
                        lanternPos.X, lanternPos.Y,
                        rayEndpoints[i].X, rayEndpoints[i].Y,
                        rayEndpoints[next].X, rayEndpoints[next].Y
                    );
                }

                // Draw light rays from lantern to intersection points
                for (int i = 0; i < numRays; i += 6)
                {
                    SplashKit.DrawLine(SplashKit.RGBAColor(255, 200, 50, 20), lanternPos, rayEndpoints[i]);
                }

                // Draw the obstacle outlines on top
                SplashKit.DrawRectangle(Color.DarkGray, obstacle1);
                SplashKit.DrawRectangle(Color.DarkGray, obstacle2);
                SplashKit.DrawRectangle(Color.DarkGray, obstacle3);

                // Fill obstacles to make them look solid
                SplashKit.FillRectangle(Color.Gray, obstacle1);
                SplashKit.FillRectangle(Color.Gray, obstacle2);
                SplashKit.FillRectangle(Color.Gray, obstacle3);

                // Draw the lantern glow at the mouse position
                SplashKit.FillCircle(Color.Yellow, lanternPos.X, lanternPos.Y, 8);
                SplashKit.FillCircle(SplashKit.RGBAColor(255, 200, 50, 100), lanternPos.X, lanternPos.Y, 20);

                // Display instructions
                SplashKit.DrawText("Move the mouse to reposition the lantern", Color.White, 10, 10);
                SplashKit.DrawText("Rays: " + numRays + " | Obstacles: 3", Color.White, 10, 30);

                SplashKit.RefreshScreen(60);
            }

            SplashKit.CloseAllWindows();
        }
    }
}
