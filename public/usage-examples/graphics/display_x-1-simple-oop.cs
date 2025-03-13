using System;
using SplashKitSDK;

namespace DisplayDetails
{
    public class Program
    {
        public static void Main()
        {
            // Declare Variables
            int DispX;
            int DispY;
            Display DispDetails;

            // Set number of displays
            int DispCount = SplashKit.NumberOfDisplays();

            SplashKit.WriteLine("***Display Coordinates***");
            SplashKit.WriteLine("********************************");
            // Loop through displays
            for (uint i = 0; i < DispCount; i++)
            {
                // Set details for display
                DispDetails = SplashKit.DisplayDetails(i);

                // Get coordinate info for display
                DispX = DispDetails.X;
                DispY = DispDetails.Y;

                // Write info to console

                SplashKit.WriteLine($"Display Number: {i + 1} is located at: {DispX}, {DispY} Coordinates on the display map");
                SplashKit.WriteLine();
            }
            SplashKit.WriteLine("********************************");
        }
    }
}