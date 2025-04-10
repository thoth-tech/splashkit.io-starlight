using SplashKitSDK;

namespace DisplayXExample
{
    public class Program
    {
        public static void Main()
        {
            // Declare Variables
            Display dispDetails;

            SplashKit.WriteLine("Display Coordinates");
            SplashKit.WriteLine("------------------------------------");
            // Loop through displays
            for (uint i = 0; i < SplashKit.NumberOfDisplays(); i++)
            {
                // Set details for display
                dispDetails = SplashKit.DisplayDetails(i);

                // Write info to console
                SplashKit.WriteLine($"Display Number: {i + 1} is located at: {dispDetails.X}, {dispDetails.Y} Coordinates on the display map");
                SplashKit.WriteLine();
            }
        }
    }
}