using SplashKitSDK;

namespace DisplayNameExample
{
    public class Program
    {
        public static void Main()
        {
            // Set number of displays
            int numDisplays = SplashKit.NumberOfDisplays();

            // Print main display details and number of displays
            SplashKit.WriteLine($"Your main display is called: {SplashKit.DisplayDetails(0).Name}");
            SplashKit.WriteLine($"You have {numDisplays} displays connected.");

            // Print names for secondary displays
            SplashKit.WriteLine("Your secondary displays are called: ");
            for (uint i = 1; i < numDisplays; i++)
            {
                SplashKit.WriteLine(SplashKit.DisplayDetails(i).Name);
            }
        }
    }
}
