using SplashKitSDK;

namespace TextHeight
{
    public class Program
    {
        public static void Main()
        {
            // Let user enter the text
            SplashKit.WriteLine("Type some text: ");
            string text = SplashKit.ReadLine();

            // Let user enter the size
            SplashKit.WriteLine("Enter the size for the text: ");
            int size = SplashKit.ConvertToInteger(SplashKit.ReadLine());

            SplashKit.OpenWindow("Text Height", 800, 600);
            SplashKit.ClearScreen();

            // Load font
            SplashKit.LoadFont("my_font", "arial.ttf");

            // Calculate the text height with size enter by user
            int textHeight = SplashKit.TextHeight(text, "my_font", size);

            // Display the height of text.
            SplashKit.WriteLine("The height of the text is: " + textHeight);

            // Display the text in the window
            SplashKit.DrawText(text, Color.Black, "my_font", size, 100, 100);

            SplashKit.RefreshScreen();
            SplashKit.Delay(4000);
            SplashKit.CloseAllWindows();
        }
    }
}

