using SplashKitSDK;

namespace TextHeight
{
    public class Program
    {
        public static void Main()
        {           
            SplashKit.OpenWindow("Text Height", 800, 600);
            SplashKit.ClearScreen();

            string text = "Text Height!";

            // Load font
            SplashKit.LoadFont("my_font", "arial.ttf");
            // Calculate the text width, 0 for normal font, and 16 is the font size
            int textHeight = SplashKit.TextHeight(text, "my_font", 16);

            //Calculate the x and y position to make the text align it vertically in the window
            int xPosition = 200;
            int yPosition = (600-textHeight) / 2;

            // Display the text align it vertically in the window
            SplashKit.DrawText(text, Color.Black, xPosition, yPosition);

            SplashKit.RefreshScreen();
            SplashKit.Delay(4000);
            SplashKit.CloseAllWindows();
        }    
    }
}

