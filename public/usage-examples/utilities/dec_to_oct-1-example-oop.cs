using SplashKitSDK;

namespace DecToOctExample
{
    public static class Program
    {
        public static void Main()
        {
            SplashKit.OpenWindow("Octal Receipt Codes", 700, 360);

            // Each order number is printed on its receipt as a short octal code
            uint[] orderNumbers = { 8, 64, 500, 4095 };

            while (!SplashKit.QuitRequested())
            {
                SplashKit.ProcessEvents();

                SplashKit.ClearScreen(Color.White);

                SplashKit.DrawText("Order number", Color.Black, 60, 40);
                SplashKit.DrawText("Receipt code (octal)", Color.Black, 300, 40);
                SplashKit.DrawLine(Color.Black, 40, 70, 660, 70);

                for (int row = 0; row < orderNumbers.Length; row++)
                {
                    string receiptCode = SplashKit.DecToOct(orderNumbers[row]);
                    double rowY = 100 + row * 50;

                    SplashKit.DrawText(orderNumbers[row].ToString(), Color.Black, 60, rowY);
                    SplashKit.DrawText(receiptCode, Color.Blue, 300, rowY);
                }

                SplashKit.RefreshScreen(60);
            }

            SplashKit.CloseAllWindows();
        }
    }
}
