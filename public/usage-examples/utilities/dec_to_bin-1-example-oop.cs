using SplashKitSDK;

namespace DecToBinExample
{
    public static class Program
    {
        public static void Main()
        {
            SplashKit.OpenWindow("LED Bit Display", 800, 300);

            // The bits come back as text, one character for each LED
            uint displayValue = 178;
            string bits = SplashKit.DecToBin(displayValue);

            while (!SplashKit.QuitRequested())
            {
                SplashKit.ProcessEvents();

                SplashKit.ClearScreen(Color.White);

                SplashKit.DrawText("Number: " + displayValue, Color.Black, 40, 40);
                SplashKit.DrawText("Binary: " + bits, Color.Black, 40, 80);

                // A lit LED is a 1 bit and a dark LED is a 0 bit
                int ledX = 80;
                foreach (char bit in bits)
                {
                    if (bit == '1')
                    {
                        SplashKit.FillCircle(Color.Yellow, ledX, 190, 32);
                    }
                    else
                    {
                        SplashKit.FillCircle(Color.LightGray, ledX, 190, 32);
                    }

                    SplashKit.DrawCircle(Color.Black, ledX, 190, 32);
                    ledX += 90;
                }

                SplashKit.RefreshScreen(60);
            }

            SplashKit.CloseAllWindows();
        }
    }
}
