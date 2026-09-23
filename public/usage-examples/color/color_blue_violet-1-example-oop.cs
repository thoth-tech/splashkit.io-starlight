using SplashKitSDK;

namespace ColorBlueVioletExample
{
    public class Program
    {
        public static void Main()
        {
            SplashKit.OpenWindow("Color Blue Violet", 500, 500);

            SplashKit.ClearScreen(Color.White);

            // Draw 8 circles from largest to smallest to create a set of rings
            for (int i = 0; i < 8; i++)
            {
                double radius = 200 - i * 25;

                if (i % 2 == 0)
                {
                    // Function used here ↓
                    SplashKit.FillCircle(Color.BlueViolet, 250, 250, radius);
                }
                else
                {
                    // The white circles cut the rings out of the blue violet ones
                    SplashKit.FillCircle(Color.White, 250, 250, radius);
                }
            }

            SplashKit.DrawText("Rings drawn with Color.BlueViolet", Color.BlueViolet, 155, 470);

            SplashKit.RefreshScreen();

            SplashKit.Delay(5000);

            SplashKit.CloseAllWindows();
        }
    }
}
