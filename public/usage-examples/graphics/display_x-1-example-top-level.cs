using SplashKitSDK;
using static SplashKitSDK.SplashKit;

// Declare Variables
Display dispDetails;

WriteLine("Display Coordinates");
WriteLine("------------------------------------");
// Loop through displays
for (uint i = 0; i < NumberOfDisplays(); i++)
{
    // Set details for display
    dispDetails = DisplayDetails(i);

    // Write info to console
    WriteLine($"Display Number: {i + 1} is located at: {DisplayX(dispDetails)}, {DisplayY(dispDetails)} Coordinates on the display map");
    WriteLine();
}