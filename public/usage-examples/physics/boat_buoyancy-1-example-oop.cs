using SplashKitSDK;
using static SplashKitSDK.SplashKit;

namespace BoatBuoyancyExample
{
    public class Program
    {
        public static void Main()
        {
            // This example demonstrates a simple buoyancy simulation.
            // The boat first falls because of gravity.
            // Once the bottom of the boat goes below the water surface,
            // buoyancy pushes it upward based on how deep it is submerged.
            // Damping is also used so the boat settles instead of bouncing forever.

            OpenWindow("Boat Buoyancy", 800, 600);

            // Create a bitmap for the boat so the program is self-contained
            Bitmap boatBitmap = CreateBitmap("boat_bitmap", 120, 50);
            ClearBitmap(boatBitmap, Color.Transparent);

            // Draw a simple boat shape so the motion is easy to see
            FillRectangleOnBitmap(boatBitmap, Color.Brown, 10, 20, 100, 20);
            FillTriangleOnBitmap(boatBitmap, Color.Red, 20, 20, 60, 0, 100, 20);

            // Create a sprite from the bitmap so it can be moved around the screen
            Sprite boat = CreateSprite(boatBitmap);

            // Start the boat well above the water so the falling motion is clearly visible
            SpriteSetX(boat, 340);
            SpriteSetY(boat, 20);

            // Define the water area
            Rectangle waterArea = RectangleFrom(0, 350, 800, 250);
            double waterSurface = waterArea.Y;

            // These values are tuned so the boat sinks a little, then rises and settles
            double gravityStrength = 0.7;
            double dampingStrength = 0.05;
            double buoyancyScale = 0.05;

            // Track vertical motion manually
            double verticalVelocity = 0;

            while (!QuitRequested())
            {
                ProcessEvents();

                // Gravity always pulls the boat downward
                // This makes the boat fall naturally before water begins pushing back
                verticalVelocity += gravityStrength;

                // Find the bottom of the boat
                // Using the bottom gives a more believable buoyancy trigger than a collision circle
                double boatBottom = SpriteY(boat) + SpriteHeight(boat);

                // Only apply buoyancy after the boat has actually gone below the water surface
                // This allows the boat to sink slightly first instead of floating too early
                if (boatBottom > waterSurface)
                {
                    // Calculate how deep the boat is below the water surface
                    double submergedDepth = boatBottom - waterSurface;

                    // Limit the depth so the upward push does not become unrealistically strong
                    if (submergedDepth > SpriteHeight(boat))
                    {
                        submergedDepth = SpriteHeight(boat);
                    }

                    // The deeper the boat goes, the stronger the upward buoyancy becomes
                    double upwardForce = submergedDepth * buoyancyScale;

                    // Use VectorFromAngle so the example still demonstrates upward vector creation
                    Vector2D buoyancy = VectorFromAngle(270, upwardForce);

                    // Apply the vertical part of the buoyancy vector
                    verticalVelocity += buoyancy.Y;
                }

                // Damping reduces repeated bouncing and helps the boat stabilise
                verticalVelocity *= (1.0 - dampingStrength);

                // Move the boat using the current vertical speed
                SpriteSetY(boat, SpriteY(boat) + verticalVelocity);

                ClearScreen(Color.White);

                // Create the water shape as a quad because DrawQuad needs a quad object
                Quad waterQuad = QuadFrom(
                    PointAt(0, 350),
                    PointAt(800, 350),
                    PointAt(0, 600),
                    PointAt(800, 600)
                );

                // Draw the water so it is clear where buoyancy begins
                DrawQuad(Color.DeepSkyBlue, waterQuad);

                // Draw the water surface line
                DrawLine(Color.Blue, 0, 350, 800, 350);

                // Draw the boat
                DrawSprite(boat);

                // Show motion information so the effect is easier to understand
                DrawText("Boat falls, sinks slightly, then floats.", Color.Black, 20, 20);
                DrawText("Vertical Velocity: " + verticalVelocity, Color.Black, 20, 50);

                RefreshScreen(60);
            }
        }
    }
}