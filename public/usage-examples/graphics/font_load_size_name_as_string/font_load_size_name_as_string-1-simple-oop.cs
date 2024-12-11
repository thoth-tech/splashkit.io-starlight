using SplashKitSDK;

namespace SpriteRectangleCollisionDemo
{
    public class Program
    {
        public static void Main()
        {
            // Load font and size 
            SplashKit.LoadFont("BebasNeue", "BebasNeue.ttf");
            SplashKit.FontLoadSize("BebasNeue", 20);

            // Prompt user 
            SplashKit.Write("What size would you like to check?: ");
            string input = SplashKit.ReadLine();

            // Convert input to integer 
            int size = SplashKit.ConvertToInteger(input);
            bool isSize = SplashKit.FontHasSize("BebasNeue", size);
            
            // If user input is size of font 
            if (isSize)
            {
                SplashKit.WriteLine("APPROVED");
                SplashKit.WriteLine("Current font size is " + input);
            }
            else // If user input is not size of font
            {
                SplashKit.WriteLine("ERROR");
                SplashKit.WriteLine("Font size is NOT " + input);
            }

        }
    }
}