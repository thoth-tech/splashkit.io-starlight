using System;
using SplashKitSDK;

namespace DisplayDetails
{
    public class Program
    {
        public static void Main()
        {
            // Set number of displays
            int DispCount = SplashKit.NumberOfDisplays();

            // Declare Variables
            int[] DispY = new int[DispCount];
            Display DispDetails;

            // Check for more that 1 display
            if (DispCount > 1)
            {
                // Loop through displays
                for (uint i = 0; i < DispCount; i++)
                {
                    // Get details for display
                    DispDetails = SplashKit.DisplayDetails(i);

                    // Get Y coordinate info for display
                    DispY[i] = DispDetails.Y;
                }
                // Check that all displays are on the same Y to determine verticality  
                for (int i = 0; i < DispY.Length - 1; i++)
                {
                    if (DispY[i] != DispY[i + 1])
                    {
                        SplashKit.WriteLine("Your displays are at different heights");
                        break;
                    }
                }

            }
            else { SplashKit.WriteLine("You only have 1 Display"); }
        }

    }
}