using SplashKitSDK;
using static SplashKitSDK.SplashKit;

// Declare Variables
int DispX;
int DispY;
Display DispDetails;
string DispName;

// Set number of displays
int DispCount = NumberOfDisplays();

WriteLine("***Display Coordinates***");
WriteLine("********************************");
// Loop through displays
for (uint i = 0; i < DispCount; i++)
{
    // Set details for display
    DispDetails = DisplayDetails(i);

    // Get coordinate info for display
    DispX = DisplayX(DispDetails);
    DispY = DisplayY(DispDetails);


    // Get name for display
    DispName = DisplayName(DispDetails);

    // Write info to console

    WriteLine($"Display Number: {i + 1} is located at: {DispX}, {DispY} Coordinates on the display map");
    WriteLine();
}
WriteLine("********************************");