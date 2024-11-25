using SplashKitSDK;

namespace TextWidth
{
    public class Program
    {
        public static void Main()
        {           
            SplashKit.OpenWindow("Text Width", 800, 600);
            SplashKit.ClearScreen();

            string text = "Text Width!";

            // Load font
            SplashKit.LoadFont("my_font", "arial.ttf");
            // Calculate the text width, 0 for normal font, and 16 is the font size
            int textWidth = SplashKit.TextWidth(text, "my_font", 16);

            // Calculate the x and y position to make the text in the center of the window
            int xPosition = (800 - textWidth) / 2;
            int yPosition = 600 / 2;

            // Display the text in the center of the window
            SplashKit.DrawText(text, Color.Black, xPosition, yPosition);

            SplashKit.RefreshScreen();
            SplashKit.Delay(4000);
            SplashKit.CloseAllWindows();
        }    
    }
}

