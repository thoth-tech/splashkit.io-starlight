using SplashKitSDK;
using static SplashKitSDK.SplashKit;

OpenWindow("Boat Buoyancy", 800, 600);

// Create a simple boat shape for the simulation
Bitmap boatBitmap = CreateBitmap("boat_bitmap", 120, 50);
ClearBitmap(boatBitmap, Color.Transparent);

FillRectangleOnBitmap(boatBitmap, Color.Brown, 10, 20, 100, 20);
FillTriangleOnBitmap(boatBitmap, Color.Red, 20, 20, 60, 0, 100, 20);

Sprite boat = CreateSprite(boatBitmap);

// Position the boat above the water
SpriteSetX(boat, 340);
SpriteSetY(boat, 20);

// Define the water area and surface level
Rectangle waterArea = RectangleFrom(0, 350, 800, 250);
double waterSurface = waterArea.Y;

double gravityStrength = 0.7;
double dampingStrength = 0.05;
double buoyancyScale = 0.05;

double verticalVelocity = 0;

while (!QuitRequested())
{
    ProcessEvents();

    // Apply gravity to pull the boat downward
    verticalVelocity += gravityStrength;

    double boatBottom = SpriteY(boat) + SpriteHeight(boat);

    // Check how much of the boat is underwater
    if (boatBottom > waterSurface)
    {
        double submergedDepth = boatBottom - waterSurface;

        // Limit buoyancy so the force stays stable
        if (submergedDepth > SpriteHeight(boat))
        {
            submergedDepth = SpriteHeight(boat);
        }

        // Apply upward force based on submerged depth
        double upwardForce = submergedDepth * buoyancyScale;
        Vector2D buoyancy = VectorFromAngle(270, upwardForce);

        verticalVelocity += buoyancy.Y;
    }

    // Reduce movement over time for smoother floating
    verticalVelocity *= (1.0 - dampingStrength);

    // Update the boat position using velocity
    SpriteSetY(boat, SpriteY(boat) + verticalVelocity);

    ClearScreen(Color.White);

    // Draw the water area and surface
    Quad waterQuad = QuadFrom(
        PointAt(0, 350),
        PointAt(800, 350),
        PointAt(0, 600),
        PointAt(800, 600)
    );

    DrawQuad(Color.DeepSkyBlue, waterQuad);
    DrawLine(Color.Blue, 0, 350, 800, 350);

    // Display the boat sprite
    DrawSprite(boat);

    // Show the current movement speed
    DrawText("Boat floats using vector based buoyancy.", Color.Black, 20, 20);
    DrawText("Vertical Velocity: " + verticalVelocity, Color.Black, 20, 50);

    RefreshScreen(60);
}

CloseAllWindows();
