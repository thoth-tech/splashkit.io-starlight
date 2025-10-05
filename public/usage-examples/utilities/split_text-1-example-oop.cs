using System;
using SplashKitSDK;

namespace SplitTextExample
{
    public class SplitText
    {
        private Window _window;
        private string _text;
        private string[] _parts;
        private Color _topColor;
        private Color _bottomColor;

        public SplitText()
        {
            // creating window
            _window = new Window("Split Text Example", 800, 400);

            // I am defining the text to split
            _text = "apple,banana,carrot";

            // I am splitting the string into parts using SplashKit's split() function
            _parts = SplashKit.Split(_text, ',');

            // colors for background gradient
            _topColor = SplashKit.RGBColor(245, 251, 255);
            _bottomColor = SplashKit.RGBColor(200, 230, 255);
        }

        private Color BlendColors(Color c1, Color c2, double t)
        {
            // linear interpolation for RGB channels
            int r = (int)((1 - t) * SplashKit.RedOf(c1) + t * SplashKit.RedOf(c2));
            int g = (int)((1 - t) * SplashKit.GreenOf(c1) + t * SplashKit.GreenOf(c2));
            int b = (int)((1 - t) * SplashKit.BlueOf(c1) + t * SplashKit.BlueOf(c2));
            return SplashKit.RGBColor(r, g, b);
        }

        public void Run()
        {
            while (!SplashKit.QuitRequested())
            {
                SplashKit.ProcessEvents();

                // draw gradient background
                for (int y = 0; y < _window.Height; y++)
                {
                    double t = (double)y / _window.Height;
                    Color blended = BlendColors(_topColor, _bottomColor, t);
                    SplashKit.DrawLine(blended, 0, y, _window.Width, y);
                }

                // display text
                SplashKit.DrawText("Original string:", SplashKit.ColorDarkBlue(), "arial", 20, 60, 50);
                SplashKit.DrawText(_text, SplashKit.ColorBlack(), "arial", 20, 280, 50);

                int yPos = 130;
                foreach (string s in _parts)
                {
                    SplashKit.DrawText("Token: " + s, SplashKit.ColorBlack(), "arial", 18, 60, yPos);
                    yPos += 40;
                }

                SplashKit.DrawText("Press ESC to exit", SplashKit.ColorGray(), "arial", 14, 620, 360);
                _window.Refresh(60);

                if (SplashKit.KeyTyped(KeyCode.EscapeKey))
                {
                    break;
                }
            }

            _window.Close();
        }

        public static void Main()
        {
            SplitText demo = new SplitText();
            demo.Run();
        }
    }
}
