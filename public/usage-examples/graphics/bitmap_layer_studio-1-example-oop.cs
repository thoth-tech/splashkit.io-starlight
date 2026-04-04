using SplashKitSDK;

namespace BitmapLayerStudio
{
    public class Program
    {
        public static void Main()
        {
            Window window = new Window("Bitmap Layer Studio", 960, 540);

            // Scene setup: open window and load four bitmap layers.
            Bitmap backgroundLayer = SplashKit.LoadBitmap("background_layer", "layer_background.png");
            Bitmap midLayer = SplashKit.LoadBitmap("mid_layer", "layer_midground.png");
            Bitmap propsLayer = SplashKit.LoadBitmap("props_layer", "layer_props.png");
            Bitmap foregroundLayer = SplashKit.LoadBitmap("foreground_layer", "layer_foreground.png");

            double alpha = 0.45;
            int bgRed = 48;
            int bgGreen = 88;
            int bgBlue = 128;
            int fgRed = 250;
            int fgGreen = 216;
            int fgBlue = 126;

            // Formula layer: C_out = alpha * C_fg + (1 - alpha) * C_bg.
            int outRed = (int)(alpha * fgRed + (1.0 - alpha) * bgRed);
            int outGreen = (int)(alpha * fgGreen + (1.0 - alpha) * bgGreen);
            int outBlue = (int)(alpha * fgBlue + (1.0 - alpha) * bgBlue);
            Color blendGuide = SplashKit.RGBAColor(outRed, outGreen, outBlue, 255);
            Color overlayGuide = SplashKit.RGBAColor(fgRed, fgGreen, fgBlue, (int)(alpha * 255));

            while (!SplashKit.QuitRequested())
            {
                SplashKit.ProcessEvents();
                SplashKit.ClearScreen();

                // Layer pipeline: draw bitmaps back-to-front for stable compositing.
                SplashKit.DrawBitmap(backgroundLayer, 0, 0);
                SplashKit.DrawBitmap(midLayer, 0, 0);
                SplashKit.DrawBitmap(propsLayer, 0, 0);
                SplashKit.DrawBitmap(foregroundLayer, 0, 0);

                // Visual pass: draw depth guides and decorative perspective lines.
                SplashKit.DrawLine(blendGuide, 0, 370, 960, 370);
                SplashKit.DrawLine(overlayGuide, 480, 120, 180, 520);
                SplashKit.DrawLine(overlayGuide, 480, 120, 780, 520);
                SplashKit.DrawLine(blendGuide, 120, 500, 840, 500);

                SplashKit.RefreshScreen(60);
            }

            SplashKit.FreeAllBitmaps();
            window.Close();
        }
    }
}
