using System;
using SplashKitSDK;

namespace DisplayDetails
{
    public class Program
    {
        public static void Main()
        {
            // Declare Variables
            Display dispDetails;

            SplashKit.WriteLine("***Display Info***");

            // Loop through displays
            for (uint i = 0; i < SplashKit.NumberOfDisplays(); i++)
            {
                // Set details for display
                dispDetails = SplashKit.DisplayDetails(i);

                // Write info to console
                SplashKit.WriteLine("********************************");
                SplashKit.WriteLine($"  Display Number: {i + 1}");
                SplashKit.WriteLine($"   Name: {dispDetails.Name}");
                SplashKit.WriteLine($"   Coordinates (X,Y): {dispDetails.X}, {dispDetails.Y}");
                SplashKit.WriteLine($"   Resolution: {dispDetails.Width}x{dispDetails.Height}");
            }
            SplashKit.WriteLine("********************************");
        }
    }
}
