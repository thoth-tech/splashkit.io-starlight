using SplashKitSDK;
using static SplashKitSDK.SplashKit;

// Constants for physics
const double G = 10.0; // Scaled Gravitational Constant for visual appeal
const int WINDOW_WIDTH = 800;
const int WINDOW_HEIGHT = 600;

OpenWindow("Celestial Mechanics", WINDOW_WIDTH, WINDOW_HEIGHT);

// Load a simple circle bitmap for planets
Bitmap planetBmp = CreateBitmap("planet", 20, 20);
ClearBitmap(planetBmp, ColorTransparent());
FillCircleOnBitmap(planetBmp, ColorWhite(), 10, 10, 10);

// Create 3 planetary Sprites with varying masses
// Sun-like mass
Sprite sun = CreateSprite(planetBmp);
SpriteSetX(sun, WINDOW_WIDTH / 2 - 10);
SpriteSetY(sun, WINDOW_HEIGHT / 2 - 10);
SpriteSetMass(sun, 1000.0);

// Planet-like mass
Sprite planet = CreateSprite(planetBmp);
SpriteSetX(planet, WINDOW_WIDTH / 2 + 150);
SpriteSetY(planet, WINDOW_HEIGHT / 2 - 10);
SpriteSetMass(planet, 10.0);
SpriteSetVelocity(planet, VectorTo(0, 8)); // Vertical tangent velocity

// Moon-like mass
Sprite moon = CreateSprite(planetBmp);
SpriteSetX(moon, WINDOW_WIDTH / 2 + 170);
SpriteSetY(moon, WINDOW_HEIGHT / 2 - 10);
SpriteSetMass(moon, 1.0);
SpriteSetVelocity(moon, VectorTo(0, 10));

Sprite[] bodies = { sun, planet, moon };

while (!QuitRequested())
{
    ProcessEvents();

    // N-Body Gravity Calculation
    for (int i = 0; i < bodies.Length; i++)
    {
        for (int j = 0; j < bodies.Length; j++)
        {
            if (i == j) continue;

            // Position difference
            Point2D p1 = SpritePosition(bodies[i]);
            Point2D p2 = SpritePosition(bodies[j]);

            // direction = p2 - p1
            Vector2D direction = VectorTo(p2.X - p1.X, p2.Y - p1.Y);
            double distance = VectorMagnitude(direction);

            // Prevent division by zero and extreme forces when overlapping
            if (distance < 5.0) distance = 5.0;

            // F = G * (m1 * m2) / r^2
            double forceMagnitude = (G * SpriteMass(bodies[i]) * SpriteMass(bodies[j])) / (distance * distance);

            // Apply force to body i towards body j (Acceleration = F/m)
            Vector2D forceVector = VectorMultiply(UnitVector(direction), forceMagnitude);
            Vector2D acceleration = VectorMultiply(forceVector, 1.0 / SpriteMass(bodies[i]));
            SpriteSetVelocity(bodies[i], VectorAdd(SpriteVelocity(bodies[i]), acceleration));
        }
    }

    // Update movement
    foreach (Sprite body in bodies)
    {
        UpdateSprite(body);
    }

    // Rendering
    ClearScreen(ColorBlack());
    
    foreach (Sprite body in bodies)
    {
        DrawSprite(body);
    }

    RefreshScreen(60);
}

CloseAllWindows();
