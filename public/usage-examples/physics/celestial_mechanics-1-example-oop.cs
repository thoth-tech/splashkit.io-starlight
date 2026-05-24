using SplashKitSDK;
using System.Collections.Generic;

namespace CelestialMechanics
{
    public class Program
    {
        // Constants for physics
        private const double G = 10.0; // Scaled Gravitational Constant for visual appeal
        private const int WINDOW_WIDTH = 800;
        private const int WINDOW_HEIGHT = 600;

        public static void Main()
        {
            SplashKit.OpenWindow("Celestial Mechanics", WINDOW_WIDTH, WINDOW_HEIGHT);

            // Load a simple circle bitmap for planets
            Bitmap planetBmp = SplashKit.CreateBitmap("planet", 20, 20);
            SplashKit.ClearBitmap(planetBmp, SplashKit.ColorTransparent());
            SplashKit.FillCircleOnBitmap(planetBmp, SplashKit.ColorWhite(), 10, 10, 10);

            // Create 3 planetary Sprites with varying masses
            // Sun-like mass
            Sprite sun = SplashKit.CreateSprite(planetBmp);
            SplashKit.SpriteSetX(sun, WINDOW_WIDTH / 2 - 10);
            SplashKit.SpriteSetY(sun, WINDOW_HEIGHT / 2 - 10);
            SplashKit.SpriteSetMass(sun, 1000.0);

            // Planet-like mass
            Sprite planet = SplashKit.CreateSprite(planetBmp);
            SplashKit.SpriteSetX(planet, WINDOW_WIDTH / 2 + 150);
            SplashKit.SpriteSetY(planet, WINDOW_HEIGHT / 2 - 10);
            SplashKit.SpriteSetMass(planet, 10.0);
            SplashKit.SpriteSetVelocity(planet, SplashKit.VectorTo(0, 8)); // Vertical tangent velocity

            // Moon-like mass
            Sprite moon = SplashKit.CreateSprite(planetBmp);
            SplashKit.SpriteSetX(moon, WINDOW_WIDTH / 2 + 170);
            SplashKit.SpriteSetY(moon, WINDOW_HEIGHT / 2 - 10);
            SplashKit.SpriteSetMass(moon, 1.0);
            SplashKit.SpriteSetVelocity(moon, SplashKit.VectorTo(0, 10));

            List<Sprite> bodies = new List<Sprite> { sun, planet, moon };

            while (!SplashKit.QuitRequested())
            {
                SplashKit.ProcessEvents();

                // N-Body Gravity Calculation
                for (int i = 0; i < bodies.Count; i++)
                {
                    for (int j = 0; j < bodies.Count; j++)
                    {
                        if (i == j) continue;

                        // Position difference
                        Point2D p1 = SplashKit.SpritePosition(bodies[i]);
                        Point2D p2 = SplashKit.SpritePosition(bodies[j]);

                        // direction = p2 - p1
                        Vector2D direction = SplashKit.VectorTo(p2.X - p1.X, p2.Y - p1.Y);
                        double distance = SplashKit.VectorMagnitude(direction);

                        // Prevent division by zero and extreme forces when overlapping
                        if (distance < 5.0) distance = 5.0;

                        // F = G * (m1 * m2) / r^2
                        double forceMagnitude = (G * SplashKit.SpriteMass(bodies[i]) * SplashKit.SpriteMass(bodies[j])) / (distance * distance);

                        // Apply force to body i towards body j (Acceleration = F/m)
                        Vector2D forceVector = SplashKit.VectorMultiply(SplashKit.UnitVector(direction), forceMagnitude);
                        Vector2D acceleration = SplashKit.VectorMultiply(forceVector, 1.0 / SplashKit.SpriteMass(bodies[i]));
                        SplashKit.SpriteSetVelocity(bodies[i], SplashKit.VectorAdd(SplashKit.SpriteVelocity(bodies[i]), acceleration));
                    }
                }

                // Update movement
                foreach (Sprite body in bodies)
                {
                    SplashKit.UpdateSprite(body);
                }

                // Rendering
                SplashKit.ClearScreen(SplashKit.ColorBlack());
                
                foreach (Sprite body in bodies)
                {
                    SplashKit.DrawSprite(body);
                }

                SplashKit.RefreshScreen(60);
            }

            SplashKit.CloseAllWindows();
        }
    }
}
