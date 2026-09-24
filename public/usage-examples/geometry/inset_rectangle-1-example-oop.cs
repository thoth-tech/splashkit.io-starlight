using SplashKitSDK;

namespace InsetRectangleExample
{
    public class Program
    {
        public static void Main()
        {
            SplashKit.OpenWindow("Inset Rectangle Example", 400, 300);

            // The fixed outer rectangle
            Rectangle outerRect = SplashKit.RectangleFrom(50, 50, 300, 200);

            double insetAmount = 0;

            while (!SplashKit.QuitRequested())
            {
                SplashKit.ProcessEvents();

                SplashKit.ClearScreen(Color.White);

                // Increase or decrease the inset amount with the arrow keys
                if (SplashKit.KeyDown(KeyCode.UpKey) && insetAmount < 95)
                {
                    insetAmount += 1;
                }
                if (SplashKit.KeyDown(KeyCode.DownKey) && insetAmount > 0)
                {
                    insetAmount -= 1;
                }

                // Draw the outer rectangle
                SplashKit.DrawRectangle(Color.Black, outerRect);

                // Get and draw the inset rectangle
                Rectangle innerRect = SplashKit.InsetRectangle(outerRect, (float)insetAmount);
                SplashKit.FillRectangle(Color.Red, innerRect);

                // Display the current inset amount, fixed to the screen
                SplashKit.DrawText("Inset amount: " + SplashKit.ToString((int)insetAmount), Color.Black, 10, 10, SplashKit.OptionToScreen());

                SplashKit.RefreshScreen(60);
            }

            SplashKit.CloseAllWindows();
        }
    }
}