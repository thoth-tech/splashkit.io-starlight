// I am scaling a bitmap at draw time with OptionScaleBmp (OOP form).
// I am pressing A to make smaller; I am pressing D to make bigger; I am pressing R to reset;
// I am pressing SPACE to toggle outline; I am pressing ESC to quit.

using SplashKitSDK;

namespace GraphicsExamples
{
    public class OptionScaleBmpDemo
    {
        private Bitmap _stickerBitmap;         // I am keeping the sticker bitmap.
        private double _currentScale = 1.0;    // I am tracking the live scale.
        private const double ScaleStep = 0.1;  // I am changing scale in small steps.
        private const double MinScale = 0.2;   // I am clamping to a minimum scale.
        private const double MaxScale = 3.0;   // I am clamping to a maximum scale.
        private bool _showOutline = true;      // I am toggling a bounding outline.

        private static Bitmap MakeStickerBitmap()
        {
            // I am creating a small procedural bitmap so no external file is needed.
            int stickerWidth = 128;
            int stickerHeight = 128;
            Bitmap bmp = SplashKit.CreateBitmap("sticker", stickerWidth, stickerHeight);
            SplashKit.ClearBitmap(bmp, SplashKit.RGBAColor(255, 255, 255, 0));

            // I am drawing a light grid to show scale changes.
            for (int y = 0; y < stickerHeight; y += 16)
            {
                SplashKit.DrawLineOnBitmap(bmp, SplashKit.RGBColor(220, 220, 220), 0, y, stickerWidth, y);
            }
            for (int x = 0; x < stickerWidth; x += 16)
            {
                SplashKit.DrawLineOnBitmap(bmp, SplashKit.RGBColor(220, 220, 220), x, 0, x, stickerHeight);
            }

            // I am drawing a circle and a border so the sticker is easy to see.
            SplashKit.FillCircleOnBitmap(bmp, SplashKit.RGBColor(33, 150, 243), stickerWidth / 2, stickerHeight / 2, 36);
            SplashKit.DrawCircleOnBitmap(bmp, SplashKit.ColorBlack(), stickerWidth / 2, stickerHeight / 2, 36);
            SplashKit.DrawRectangleOnBitmap(bmp, SplashKit.ColorBlack(), 1, 1, stickerWidth - 2, stickerHeight - 2);

            return bmp;
        }

        public OptionScaleBmpDemo()
        {
            // I am opening the window with a short title; I am drawing instructions inside the window.
            SplashKit.OpenWindow("Option Scale Bmp - live", 800, 480);
            _stickerBitmap = MakeStickerBitmap();
        }

        public void Run()
        {
            // I am centering my drawing around the window middle.
            double centerX = 800 / 2.0;
            double centerY = 480 / 2.0;

            while (!SplashKit.QuitRequested())
            {
                SplashKit.ProcessEvents();

                // I am handling the controls.
                if (SplashKit.KeyTyped(KeyCode.EscapeKey))
                {
                    break;
                }
                if (SplashKit.KeyTyped(KeyCode.AKey))
                {
                    _currentScale = _currentScale - ScaleStep;
                    if (_currentScale < MinScale)
                    {
                        _currentScale = MinScale;
                    }
                }
                if (SplashKit.KeyTyped(KeyCode.DKey))
                {
                    _currentScale = _currentScale + ScaleStep;
                    if (_currentScale > MaxScale)
                    {
                        _currentScale = MaxScale;
                    }
                }
                if (SplashKit.KeyTyped(KeyCode.RKey))
                {
                    _currentScale = 1.0;
                }
                if (SplashKit.KeyTyped(KeyCode.SpaceKey))
                {
                    _showOutline = !_showOutline;
                }

                // I am clearing the frame to white.
                SplashKit.ClearScreen(SplashKit.ColorWhite());

                // I am drawing the sticker centered with the current scale applied.
                double drawX = centerX - SplashKit.BitmapWidth(_stickerBitmap) / 2.0;
                double drawY = centerY - SplashKit.BitmapHeight(_stickerBitmap) / 2.0;
                SplashKit.DrawBitmap(_stickerBitmap, drawX, drawY, SplashKit.OptionScaleBmp(_currentScale, _currentScale));

                // I am drawing an outline that matches the scaled size.
                if (_showOutline)
                {
                    double outlineWidth  = SplashKit.BitmapWidth(_stickerBitmap)  * _currentScale;
                    double outlineHeight = SplashKit.BitmapHeight(_stickerBitmap) * _currentScale;
                    SplashKit.DrawRectangle(SplashKit.ColorNavy(),
                                            centerX - outlineWidth / 2.0,
                                            centerY - outlineHeight / 2.0,
                                            outlineWidth,
                                            outlineHeight);
                }

                // I am drawing the UI hints.
                SplashKit.DrawText("A: smaller   D: bigger   R: reset   SPACE: outline   ESC: quit",
                                   SplashKit.RGBColor(0, 0, 128), 16, 16);
                SplashKit.DrawText("Scale: " + _currentScale.ToString("0.0") + " x",
                                   SplashKit.ColorBlack(), 16, 40);

                SplashKit.RefreshScreen(60);
            }

            // I am freeing the bitmap before I quit.
            SplashKit.FreeBitmap(_stickerBitmap);
        }

        public static void Main()
        {
            new OptionScaleBmpDemo().Run();
        }
    }
}