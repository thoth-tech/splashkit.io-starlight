// I am scaling a bitmap at draw time with OptionScaleBmp.
// A makes smaller; D makes bigger; R resets; SPACE toggles outline; ESC quits.

using SplashKitSDK;

namespace GraphicsExamples
{
    public class OptionScaleBmpDemo
    {
        private const int WindowWidth = 800;
        private const int WindowHeight = 480;

        private Bitmap _sticker;

        private double _scale = 1.0;
        private const double Step = 0.1;
        private const double MinScale = 0.2;
        private const double MaxScale = 3.0;

        private bool _showOutline = true;

        private static Bitmap MakeSticker()
        {
            int w = 128;
            int h = 128;
            Bitmap bmp = SplashKit.CreateBitmap("sticker", w, h);
            SplashKit.ClearBitmap(bmp, SplashKit.RGBAColor(255, 255, 255, 0));

            for (int y = 0; y < h; y += 16)
            {
                SplashKit.DrawLineOnBitmap(bmp, SplashKit.RGBColor(220, 220, 220), 0, y, w, y);
            }
            for (int x = 0; x < w; x += 16)
            {
                SplashKit.DrawLineOnBitmap(bmp, SplashKit.RGBColor(220, 220, 220), x, 0, x, h);
            }

            SplashKit.FillCircleOnBitmap(bmp, SplashKit.RGBColor(33, 150, 243), w / 2, h / 2, 36);
            SplashKit.DrawCircleOnBitmap(bmp, SplashKit.ColorBlack(), w / 2, h / 2, 36);
            SplashKit.DrawRectangleOnBitmap(bmp, SplashKit.ColorBlack(), 1, 1, w - 2, h - 2);

            return bmp;
        }

        public OptionScaleBmpDemo()
        {
            SplashKit.OpenWindow("Option Scale Bmp — live scaling", WindowWidth, WindowHeight);
            _sticker = MakeSticker();
        }

        public void Run()
        {
            double cx = WindowWidth / 2.0;
            double cy = WindowHeight / 2.0;

            while (!SplashKit.QuitRequested())
            {
                SplashKit.ProcessEvents();

                if (SplashKit.KeyTyped(KeyCode.EscapeKey))
                {
                    break;
                }
                if (SplashKit.KeyTyped(KeyCode.AKey))
                {
                    _scale = _scale - Step;
                    if (_scale < MinScale)
                    {
                        _scale = MinScale;
                    }
                }
                if (SplashKit.KeyTyped(KeyCode.DKey))
                {
                    _scale = _scale + Step;
                    if (_scale > MaxScale)
                    {
                        _scale = MaxScale;
                    }
                }
                if (SplashKit.KeyTyped(KeyCode.RKey))
                {
                    _scale = 1.0;
                }
                if (SplashKit.KeyTyped(KeyCode.SpaceKey))
                {
                    _showOutline = !_showOutline;
                }

                SplashKit.ClearScreen(SplashKit.ColorWhite());

                double x = cx - SplashKit.BitmapWidth(_sticker) / 2.0;
                double y = cy - SplashKit.BitmapHeight(_sticker) / 2.0;
                SplashKit.DrawBitmap(_sticker, x, y, SplashKit.OptionScaleBmp(_scale, _scale));

                if (_showOutline)
                {
                    double w = SplashKit.BitmapWidth(_sticker) * _scale;
                    double h = SplashKit.BitmapHeight(_sticker) * _scale;
                    SplashKit.DrawRectangle(SplashKit.ColorNavy(), cx - w / 2.0, cy - h / 2.0, w, h);
                }

                SplashKit.DrawText("A: smaller   D: bigger   R: reset   SPACE: outline   ESC: quit",
                    SplashKit.RGBColor(0, 0, 128), 16, 16);
                SplashKit.DrawText("Scale: " + _scale.ToString("0.0") + "×",
                    SplashKit.ColorBlack(), 16, 40);

                SplashKit.RefreshScreen(60);
            }

            SplashKit.FreeBitmap(_sticker);
        }

        public static void Main()
        {
            new OptionScaleBmpDemo().Run();
        }
    }
}