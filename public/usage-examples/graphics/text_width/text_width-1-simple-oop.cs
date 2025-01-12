using SplashKitSDK;

namespace TextHeightExample
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

            Window window = new Window("Text Width", 800, 600);
            window.Clear(Color.White);

            // Load font
            SplashKit.LoadFont("my_font", "arial.ttf");

            // Calculate the text width with size enter by user
            int textWidth = SplashKit.TextWidth(text, "my_font", size);

            // Display the width of text.
            SplashKit.WriteLine("The width of the text is: " + textWidth);

            // Display the text in the window
            SplashKit.DrawText(text, Color.Black, "my_font", size, 100, 100);

            window.Refresh();
            SplashKit.Delay(4000);
            window.Close();
        }
    }
}