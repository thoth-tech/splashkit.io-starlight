using System;
using SplashKitSDK;

namespace DisplayYExample
{
    public class Program
    {
        public static void Main()
        {
            // Set number of displays
            int dispCount = SplashKit.NumberOfDisplays();

            // Declare Variables
            int[] dispY = new int[dispCount];
            Display dispDetails;

            // Check for more that 1 display
            if (dispCount > 1)
            {
                // Loop through displays
                for (uint i = 0; i < dispCount; i++)
                {
                    // Get details for display
                    dispDetails = SplashKit.DisplayDetails(i);

                    // Get Y coordinate info for display
                    dispY[i] = dispDetails.Y;
                }
                // Check that all displays are on the same Y to determine verticality  
                for (int i = 0; i < dispY.Length - 1; i++)
                {
                    if (dispY[i] != dispY[i + 1])
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