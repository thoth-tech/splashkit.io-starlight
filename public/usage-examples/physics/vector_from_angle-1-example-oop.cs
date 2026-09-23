using SplashKitSDK;
using static SplashKitSDK.SplashKit;

public class Program
{
    public static void Main()
    {
        OpenWindow("Archimedes' Voyage", 800, 600);

        const double waterLevel = 350;
        const double boatWidth = 140;
        const double boatHeight = 60;

        const double gravity = 0.18;
        const double buoyancyStrength = 0.012;
        const double damping = 0.985;

        Bitmap boatBitmap = CreateBitmap(
            "archimedes_boat",
            (int)boatWidth,
            (int)boatHeight
        );

        Sprite boat = CreateSprite(boatBitmap);

        SpriteSetPosition(
            boat,
            PointAt(330, 180)
        );

        SpriteSetVelocity(
            boat,
            VectorTo(0, 0)
        );

        Rectangle water = RectangleFrom(
            0,
            waterLevel,
            800,
            250
        );

        while (!QuitRequested())
        {
            ProcessEvents();

            Vector2D velocity = SpriteVelocity(boat);

            velocity.Y += gravity;

            double boatX = SpriteX(boat);
            double boatY = SpriteY(boat);

            Rectangle boatArea = RectangleFrom(
                boatX,
                boatY,
                boatWidth,
                boatHeight
            );

            double boatBottom = boatY + boatHeight;

            double submergedDepth = Math.Max(
                0.0,
                Math.Min(
                    boatHeight,
                    boatBottom - waterLevel
                )
            );

            if (RectanglesIntersect(boatArea, water))
            {
                double forceMagnitude =
                    submergedDepth * buoyancyStrength;

                Vector2D buoyancyForce =
                    VectorFromAngle(
                        270,
                        forceMagnitude
                    );

                velocity.Y += buoyancyForce.Y;
            }

            velocity.Y *= damping;

            SpriteSetVelocity(boat, velocity);
            UpdateSprite(boat);

            boatX = SpriteX(boat);
            boatY = SpriteY(boat);

            ClearScreen(ColorSkyBlue());

            FillRectangle(
                RGBAColor(40, 130, 210, 220),
                water
            );

            Quad hull = QuadFrom(
                boatX,
                boatY,
                boatX + boatWidth,
                boatY,
                boatX + 25,
                boatY + boatHeight,
                boatX + boatWidth - 25,
                boatY + boatHeight
            );

            FillQuad(ColorRed(), hull);
            DrawQuad(ColorBlack(), hull);

            DrawLine(
                ColorBlack(),
                boatX + boatWidth / 2,
                boatY,
                boatX + boatWidth / 2,
                boatY - 80
            );

            Triangle sail = TriangleFrom(
                boatX + boatWidth / 2,
                boatY - 75,
                boatX + boatWidth / 2,
                boatY - 5,
                boatX + boatWidth / 2 + 55,
                boatY - 5
            );

            FillTriangle(ColorWhite(), sail);
            DrawTriangle(ColorBlack(), sail);

            DrawText(
                "Archimedes' Voyage",
                ColorBlack(),
                20,
                20
            );

            DrawText(
                "Gravity pulls down while buoyancy pushes upward.",
                ColorBlack(),
                20,
                50
            );

            DrawText(
                "Submerged depth: "
                + ((int)submergedDepth).ToString(),
                ColorBlack(),
                20,
                80
            );

            DrawText(
                "Vertical velocity: "
                + SpriteVelocity(boat).Y.ToString("F6"),
                ColorBlack(),
                20,
                110
            );

            RefreshScreen(60);
        }

        FreeSprite(boat);
        FreeBitmap(boatBitmap);
    }
}