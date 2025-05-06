using System;
using SplashKitSDK;
using static SplashKitSDK.SplashKit;


// Set number of displays
int dispCount = NumberOfDisplays();

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
        dispDetails = DisplayDetails(i);

        // Get Y coordinate info for display
        dispY[i] = DisplayY(dispDetails);
    }
    // Check that all displays are on the same Y to determine verticality  
    for (int i = 0; i < dispY.Length - 1; i++)
    {
        if (dispY[i] != dispY[i + 1])
        {
            WriteLine("Your displays are at different heights");
            break;
        }
    }

}
else { WriteLine("You only have 1 Display"); }
