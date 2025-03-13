using System;
using SplashKitSDK;
using static SplashKitSDK.SplashKit;


// Set number of displays
int DispCount = NumberOfDisplays();

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
        DispDetails = DisplayDetails(i);

        // Get Y coordinate info for display
        DispY[i] = DisplayY(DispDetails);
    }
    // Check that all displays are on the same Y to determine verticality  
    for (int i = 0; i < DispY.Length - 1; i++)
    {
        if (DispY[i] != DispY[i + 1])
        {
            WriteLine("Your displays are at different heights");
            break;
        }
    }

}
else { WriteLine("You only have 1 Display"); }
