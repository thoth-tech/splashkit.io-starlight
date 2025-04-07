using SplashKitSDK;

namespace DisplayNameExample
{
    public class Program
    {
        public static void Main()
        {
            // Get number of displays
            int numDisplays = SplashKit.NumberOfDisplays();

            // Print main display name and number of displays
            SplashKit.WriteLine($"The name of your main display is: {SplashKit.DisplayDetails(0).Name}");
            SplashKit.WriteLine($"You have {numDisplays} displays connected.");

            // Print names of secondary displays
            SplashKit.WriteLine("Your secondary displays are called: ");
            for (uint i = 1; i < numDisplays; i++)
            {
                SplashKit.WriteLine(SplashKit.DisplayDetails(i).Name);
            }
        }
    }
}
