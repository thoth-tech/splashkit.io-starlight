using SplashKitSDK;

// I am clipping a day/night scene to a big 3-pane window; SPACE is toggling the mode.
namespace UsageExamples.Graphics.PushClip
{
    public class Program
    {
        public static void Main()
        {
            SplashKit.OpenWindow("push_clip modern window (day/night)", 720, 405);

            // I am defining the glass rectangle using explicit values I can reuse.
            double gx = 60, gy = 40, gw = 600, gh = 300;
            Rectangle glass = SplashKit.RectangleFrom(gx, gy, gw, gh);
            bool isNight = false;

            // I am keeping speeds slow but visible.
            const double SUN_SPEED = 0.01, CLOUD_SPEED = 0.10, MOON_SPEED = 0.03;

            // I am storing star positions.
            int N = 12;
            double[] sx = {120,150,180,210,240,270,480,510,540,570,600,630};
            double[] sy = { 80, 60, 90, 70,110, 85, 75, 95, 65,105, 85, 70};

            // I am tracking moving objects.
            double sunX = 120, moonX = 500, cloudCx = 110;

            // I am keeping the cloud inside the glass.
            double cloudMin = gx + 42;
            double cloudMax = gx + gw - 72;

            while (!SplashKit.QuitRequested())
            {
                SplashKit.ProcessEvents();
                if (SplashKit.KeyTyped(KeyCode.SpaceKey))
                {
                    isNight = !isNight;
                }

                SplashKit.ClearScreen(Color.White);

                SplashKit.PushClip(glass);
                SplashKit.FillRectangle(isNight ? Color.Black : SplashKit.RGBColor(135, 206, 235), 0, 0, 720, 405);
                SplashKit.FillRectangle(SplashKit.RGBColor(0, 128, 0), 0, 260, 720, 145);

                if (isNight)
                {
                    SplashKit.FillCircle(Color.White, moonX, 120, 24);
                    SplashKit.FillCircle(Color.Black, moonX + 9, 118, 24); // crescent
                    for (int i = 0; i < N; ++i) SplashKit.DrawPixel(Color.White, sx[i], sy[i]);
                }
                else
                {
                    SplashKit.FillCircle(SplashKit.RGBColor(255, 255, 0), sunX, 120, 26);
                    double cy = 108; // 5-circle cloud
                    SplashKit.FillCircle(Color.White, cloudCx - 26, cy + 8, 16);
                    SplashKit.FillCircle(Color.White, cloudCx - 6,  cy + 0, 20);
                    SplashKit.FillCircle(Color.White, cloudCx + 18, cy + 4, 18);
                    SplashKit.FillCircle(Color.White, cloudCx + 42, cy + 10, 14);
                }

                SplashKit.FillRectangle(SplashKit.RGBColor(150, 75, 0), 520, 220, 22, 100); // trunk
                SplashKit.FillCircle(SplashKit.RGBColor(0, 128, 0), 531, 205, 46);        // crown
                SplashKit.PopClip();

                // I am drawing the 3-pane frame.
                int f = 10, m = 6;
                SplashKit.FillRectangle(Color.Black, gx - f, gy - f, gw + 2*f, f);
                SplashKit.FillRectangle(Color.Black, gx - f, gy + gh, gw + 2*f, f);
                SplashKit.FillRectangle(Color.Black, gx - f, gy - f, f, gh + 2*f);
                SplashKit.FillRectangle(Color.Black, gx + gw, gy - f, f, gh + 2*f);
                SplashKit.FillRectangle(Color.Black, gx + gw/3 - m/2, gy, m, gh);
                SplashKit.FillRectangle(Color.Black, gx + 2*gw/3 - m/2, gy, m, gh);

                SplashKit.DrawText("Press SPACE to toggle day/night", Color.Black, 18, 12);
                SplashKit.RefreshScreen(60);

                // I am updating motion.
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
}