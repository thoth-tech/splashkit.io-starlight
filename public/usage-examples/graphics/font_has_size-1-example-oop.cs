using SplashKitSDK;

namespace FontHasSizeExample
{
    public class Program
    {
        public static void Main()
        {
            // Define the font name and required size.
            string fontName = "Arial";
            int requiredSize = 12;

            // Check using the overload that takes a font name.
            bool hasSizeByName = FontHasSize(fontName, requiredSize);

            // Load a Font object with the required size.
            Font myFont = new Font("Arial", 12);
            bool hasSizeByObject = FontHasSize(myFont, requiredSize);

            // Output the results.
            SplashKit.WriteLine("Checking font using font name overload:");
            SplashKit.WriteLine($"Font {fontName} with size {requiredSize}: " + (hasSizeByName ? "Yes" : "No"));

            SplashKit.WriteLine("Checking font using font object overload:");
            SplashKit.WriteLine($"Font {myFont.Name} with size {requiredSize}: " + (hasSizeByObject ? "Yes" : "No"));

            // Keep the window open until the user quits.
            while (!SplashKit.QuitRequested())
            {
                SplashKit.ProcessEvents();
            }
        }
    }
}
