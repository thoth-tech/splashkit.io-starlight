using SplashKitSDK;

namespace BinToOctExample
{
    public static class Program
    {
        public static void Main()
        {
            SplashKit.OpenWindow("Bit Groups to Octal", 800, 360);

            string bits = "101110011";

            while (!SplashKit.QuitRequested())
            {
                SplashKit.ProcessEvents();

                SplashKit.ClearScreen(Color.White);

                string octalCode = "";

                for (int group = 0; group < 3; group++)
                {
                    // Every group of three bits is exactly one octal digit
                    string groupBits = bits.Substring(group * 3, 3);
                    string octalDigit = SplashKit.BinToOct(groupBits);
                    octalCode += octalDigit;

                    double groupX = 80 + group * 240;
                    SplashKit.FillRectangle(Color.LightBlue, groupX, 120, 160, 150);
                    SplashKit.DrawRectangle(Color.Black, groupX, 120, 160, 150);
                    SplashKit.DrawText(groupBits, Color.Black, groupX + 68, 150);
                    SplashKit.DrawText(octalDigit, Color.Blue, groupX + 76, 220);
                }

                SplashKit.DrawText("Binary: " + bits, Color.Black, 40, 40);
                SplashKit.DrawText("Octal: " + octalCode, Color.Black, 40, 75);

                SplashKit.RefreshScreen(60);
            }

            SplashKit.CloseAllWindows();
        }
    }
}
