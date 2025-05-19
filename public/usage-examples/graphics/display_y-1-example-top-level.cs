using System;
using SplashKitSDK;
using static SplashKitSDK.SplashKit;


// Set number of displays
int dispCount = NumberOfDisplays();

// Declare Variables
int[] displayYValues = new int[dispCount];
Display dispDetails;

// Only compare display positions if more than one display is connected
if (dispCount > 1)
{
    // Loop through displays
    for (uint i = 0; i < dispCount; i++)
    {
        // Get details for display
        dispDetails = DisplayDetails(i);

        // Get Y coordinate info for display
        displayYValues[i] = DisplayY(dispDetails);
    }
    // Check that all displays are aligned horizontally 
    for (int i = 0; i < displayYValues.Length - 1; i++)
    {
        if (displayYValues[i] != displayYValues[i + 1])
        {
            WriteLine("Your displays are at different heights");
            break;
        }
    }

}
else { WriteLine("You only have 1 Display"); }
