using static SplashKitSDK.SplashKit;

// Declare Variables
Display dispDetails;

WriteLine("***Display Info***");

// Loop through displays
for (uint i = 0; i < NumberOfDisplays(); i++)
{
    // Set details for display
    dispDetails = DisplayDetails(i);

    // Write info to console
    WriteLine("********************************");
    WriteLine($"  Display Number: {i + 1}");
    WriteLine($"   Name: {DisplayName(dispDetails)}");
    WriteLine($"   Coordinates (X,Y): {DisplayX(dispDetails)}, {DisplayY(dispDetails)}");
    WriteLine($"   Resolution: {DisplayWidth(dispDetails)}x{DisplayHeight(dispDetails)}");
}
WriteLine("********************************");