using static SplashKitSDK.SplashKit;


// Set number of displays
int numDisplays = NumberOfDisplays();

// Print main display details and number of displays
WriteLine($"Your main display is called: {DisplayName(DisplayDetails(0))}");
WriteLine($"You have {numDisplays} displays connected.");

// Print names for secondary displays
WriteLine("Your secondary displays are called: ");
for (uint i = 1; i < numDisplays; i++)
{
    WriteLine(DisplayName(DisplayDetails(i)));
}
