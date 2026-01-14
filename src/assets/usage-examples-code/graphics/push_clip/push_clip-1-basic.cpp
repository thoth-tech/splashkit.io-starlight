using SplashKitSDK;
using static SplashKitSDK.SplashKit;

public class Program
{
    public static void Main()
    {
        OpenWindow("push_clip modern window (day/night)", 720, 405);

        double gx = 60, gy = 40, gw = 600, gh = 300;
        Rectangle glass = RectangleFrom(gx, gy, gw, gh);
        bool isNight = false;

        const double SUN_SPEED = 0.01, CLOUD_SPEED = 0.10, MOON_SPEED = 0.03;

        int N = 12;
        double[] sx = {120,150,180,210,240,270,480,510,540,570,600,630};
        double[] sy = { 80, 60, 90, 70,110, 85, 75, 95, 65,105, 85, 70};

        double sunX = 120, moonX = 500, cloudCx = 110;

        double cloudMin = gx + 42;
        double cloudMax = gx + gw - 72;

        while (!QuitRequested())
        {
            ProcessEvents();

            if (KeyTyped(KeyCode.SpaceKey))
            {
                isNight = !isNight;
            }

            ClearScreen(Color.White);

            PushClip(glass);
            FillRectangle(isNight ? Color.Black : RGBColor(135, 206, 235), 0, 0, 720, 405);
            FillRectangle(RGBColor(0, 128, 0), 0, 260, 720, 145);

            if (isNight)
            {
                FillCircle(Color.White, moonX, 120, 24);
                FillCircle(Color.Black, moonX + 9, 118, 24); // crescent
                for (int i = 0; i < N; ++i)
                {
                    DrawPixel(Color.White, sx[i], sy[i]);
                }
            }
            else
            {
                FillCircle(RGBColor(255, 255, 0), sunX, 120, 26);
                double cy = 108; // 5-circle cloud
                FillCircle(Color.White, cloudCx - 26, cy + 8, 16);
                FillCircle(Color.White, cloudCx - 6,  cy + 0, 20);
                FillCircle(Color.White, cloudCx + 18, cy + 4, 18);
                FillCircle(Color.White, cloudCx + 42, cy + 10, 14);
            }

            FillRectangle(RGBColor(150, 75, 0), 520, 220, 22, 100); // trunk
            FillCircle(RGBColor(0, 128, 0), 531, 205, 46);          // crown
            PopClip();

            int f = 10, m = 6;
            FillRectangle(Color.Black, gx - f, gy - f, gw + 2 * f, f);
            FillRectangle(Color.Black, gx - f, gy + gh, gw + 2 * f, f);
            FillRectangle(Color.Black, gx - f, gy - f, f, gh + 2 * f);
            FillRectangle(Color.Black, gx + gw, gy - f, f, gh + 2 * f);
            FillRectangle(Color.Black, gx + gw / 3 - m / 2, gy, m, gh);
            FillRectangle(Color.Black, gx + 2 * gw / 3 - m / 2, gy, m, gh);

            DrawText("Press SPACE to toggle day/night", Color.Black, 18, 12);
            RefreshScreen(60);

            if (isNight)
            {
                moonX += MOON_SPEED;
                if (moonX > 780)
                {
                    moonX = -40;
                }
            }
            else
            {
                sunX += SUN_SPEED;
                if (sunX > 780)
                {
                    sunX = -40;
                }

                cloudCx += CLOUD_SPEED;
                if (cloudCx > cloudMax)
                {
                    cloudCx = cloudMin;
                }
            }
        }
    }
}