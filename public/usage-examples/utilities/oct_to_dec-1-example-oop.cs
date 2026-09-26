using SplashKitSDK;

namespace OctToDecExample
{
    public static class Program
    {
        public static void Main()
        {
            SplashKit.OpenWindow("Octal Value Bars", 800, 360);

            string[] octalValues = { "7", "17", "377", "777" };

            while (!SplashKit.QuitRequested())
            {
                SplashKit.ProcessEvents();

                SplashKit.ClearScreen(Color.White);

                SplashKit.DrawText("Each bar is as long as the decimal value of its octal number.", Color.Black, 40, 30);

                for (int row = 0; row < octalValues.Length; row++)
                {
                    // The result is a number, so it is turned back into text to draw it
                    uint decimalValue = SplashKit.OctToDec(octalValues[row]);
                    double rowY = 90 + row * 60;

                    SplashKit.DrawText("Octal " + octalValues[row], Color.Black, 40, rowY + 8);
                    SplashKit.FillRectangle(Color.Blue, 200, rowY, decimalValue, 30);
                    SplashKit.DrawText(decimalValue.ToString(), Color.Black, 210 + decimalValue, rowY + 8);
                }

                SplashKit.RefreshScreen(60);
            }

            SplashKit.CloseAllWindows();
        }
    }
}
