using SplashKitSDK;

namespace BoatBuoyancyExample
{
    public class Program
    {
        public static void Main()
        {
            SplashKit.OpenWindow("Boat Buoyancy", 800, 600);

            // Create a simple boat shape for the simulation
            Bitmap boatBitmap = SplashKit.CreateBitmap("boat_bitmap", 120, 50);
            SplashKit.ClearBitmap(boatBitmap, SplashKit.Color.Transparent);

            SplashKit.FillRectangleOnBitmap(boatBitmap, SplashKit.Color.Brown, 10, 20, 100, 20);
            SplashKit.FillTriangleOnBitmap(boatBitmap, SplashKit.Color.Red, 20, 20, 60, 0, 100, 20);

            Sprite boat = SplashKit.CreateSprite(boatBitmap);

            // Position the boat above the water
            SplashKit.SpriteSetX(boat, 340);
            SplashKit.SpriteSetY(boat, 20);

            // Define the water area and surface level
            Rectangle waterArea = SplashKit.RectangleFrom(0, 350, 800, 250);
            double waterSurface = waterArea.Y;

            double gravityStrength = 0.7;
            double dampingStrength = 0.05;
            double buoyancyScale = 0.05;

            double verticalVelocity = 0;

            while (!SplashKit.QuitRequested())
            {
                SplashKit.ProcessEvents();

                // Apply gravity to pull the boat downward
                verticalVelocity += gravityStrength;

                double boatBottom = SplashKit.SpriteY(boat) + SplashKit.SpriteHeight(boat);

                // Check how much of the boat is underwater
                if (boatBottom > waterSurface)
                {
                    double submergedDepth = boatBottom - waterSurface;

                    // Limit buoyancy so the force stays stable
                    if (submergedDepth > SplashKit.SpriteHeight(boat))
                    {
                        submergedDepth = SplashKit.SpriteHeight(boat);
                    }

                    // Apply upward force based on submerged depth
                    double upwardForce = submergedDepth * buoyancyScale;
                    Vector2D buoyancy = SplashKit.VectorFromAngle(270, upwardForce);

                    verticalVelocity += buoyancy.Y;
                }

                // Reduce movement over time for smoother floating
                verticalVelocity *= (1.0 - dampingStrength);

                // Update the boat position using velocity
                SplashKit.SpriteSetY(boat, SplashKit.SpriteY(boat) + verticalVelocity);

                SplashKit.ClearScreen(SplashKit.Color.White);

                // Draw the water area and surface
                Quad waterQuad = SplashKit.QuadFrom(
                    SplashKit.PointAt(0, 350),
                    SplashKit.PointAt(800, 350),
                    SplashKit.PointAt(0, 600),
                    SplashKit.PointAt(800, 600)
                );

                SplashKit.DrawQuad(SplashKit.Color.DeepSkyBlue, waterQuad);
                SplashKit.DrawLine(SplashKit.Color.Blue, 0, 350, 800, 350);

                // Display the boat sprite
                SplashKit.DrawSprite(boat);

                // Show the current movement speed
                SplashKit.DrawText("Boat floats using vector based buoyancy.", SplashKit.Color.Black, 20, 20);
                SplashKit.DrawText("Vertical Velocity: " + verticalVelocity, SplashKit.Color.Black, 20, 50);

                SplashKit.RefreshScreen(60);
            }

            SplashKit.CloseAllWindows();
        }
    }
}
