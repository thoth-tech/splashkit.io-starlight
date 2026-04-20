// I am demonstrating creating, animating, and freeing a bitmap in OOP form with a new color each load.
// L loads (creates) the bitmap in a random color; F frees it; ESC quits.

using SplashKitSDK;

namespace GraphicsExamples
{
    public class FreeBitmapBasic
    {
        private Bitmap? _demo;
        private bool _loaded;
        private int _loadCount;
        private double _t;

        public FreeBitmapBasic()
        {
            SplashKit.OpenWindow("Free Bitmap - load, animate, free", 720, 405);
            _demo = null;
            _loaded = false;
            _loadCount = 0;
            _t = 0.0;
        }

        private SplashKitSDK.Color RandomColor()
        {
            return SplashKit.RGBColor((byte)SplashKit.Rnd(0, 255),
                                      (byte)SplashKit.Rnd(0, 255),
                                      (byte)SplashKit.Rnd(0, 255));
        }

        private void MakeDemo()
        {
            _demo = SplashKit.CreateBitmap("demo_bmp", 96, 96);
            var c = RandomColor();
            SplashKit.FillRectangleOnBitmap(_demo, c, 0, 0, 96, 96);
            SplashKit.DrawRectangleOnBitmap(_demo, SplashKit.ColorBlack(), 0, 0, 96, 96);
            _loaded = true;
            _loadCount = _loadCount + 1;
        }

        public void Run()
        {
            while (!SplashKit.QuitRequested())
            {
                SplashKit.ProcessEvents();

                if (SplashKit.KeyTyped(KeyCode.EscapeKey))
                {
                    break;
                }
                if (SplashKit.KeyTyped(KeyCode.LKey))
                {
                    if (_loaded && _demo != null)
                    {
                        SplashKit.FreeBitmap(_demo);
                        _loaded = false;
                        _demo = null;
                    }
                    MakeDemo();
                }
                if (SplashKit.KeyTyped(KeyCode.FKey))
                {
                    if (_loaded && _demo != null)
                    {
                        SplashKit.FreeBitmap(_demo);
                        _loaded = false;
                        _demo = null;
                    }
                }

                SplashKit.ClearScreen(SplashKit.ColorWhite());

                if (_loaded && _demo != null)
                {
                    _t = _t + 0.06;
                    int cx = 720 / 2 - 48;
                    int cy = 405 / 2 - 48 + (int)(8.0 * System.Math.Sin(_t));

                    SplashKit.DrawText("Status: Loaded  |  L: load  F: free  ESC: quit",
                        SplashKit.ColorBlack(), 16, 16);
                    SplashKit.DrawText($"Loads: {_loadCount}", SplashKit.ColorBlack(), 720 - 110, 16);

                    SplashKit.DrawBitmap(_demo, cx, cy);
                }
                else
                {
                    SplashKit.DrawText("Status: Freed  |  L: load  F: free  ESC: quit",
                        SplashKit.ColorBlack(), 16, 16);
                    SplashKit.DrawRectangle(SplashKit.RGBColor(128, 128, 128),
                        720 / 2 - 48, 405 / 2 - 48, 96, 96);
                    SplashKit.DrawText("Freed", SplashKit.RGBColor(128, 128, 128),
                        720 / 2 - 20, 405 / 2 - 8);
                }

                SplashKit.RefreshScreen(60);
            }

            if (_loaded && _demo != null)
            {
                SplashKit.FreeBitmap(_demo);
            }
        }

        public static void Main()
        {
            var demo = new FreeBitmapBasic();
            demo.Run();
        }
    }
}