using SplashKitSDK;

namespace DisplayNameExample
{
    public class Program
    {
        public static void Main()
        {
            // Get number of displays
            int numDisplays = SplashKit.NumberOfDisplays();
            string dispName = SplashKit.DisplayDetails(0).Name;

            // Print main display name and number of displays
            SplashKit.WriteLine($"The name of your main display is: {dispName}");
            SplashKit.WriteLine($"You have {numDisplays} displays connected.");

            // Print names of secondary displays
            SplashKit.WriteLine("Your secondary displays are called: ");
            for (uint i = 1; i < numDisplays; i++)
            {
                dispName = SplashKit.DisplayDetails(i).Name;
                SplashKit.WriteLine(dispName);
            }
        }
    }
}
