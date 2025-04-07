using static SplashKitSDK.SplashKit;


// Get number of displays
int numDisplays = NumberOfDisplays();

// Print main display name and number of displays
WriteLine($"The name of your main display is: {DisplayName(DisplayDetails(0))}");
WriteLine($"You have {numDisplays} displays connected.");

// Print names of secondary displays
WriteLine("Your secondary displays are called: ");
for (uint i = 1; i < numDisplays; i++)
{
    WriteLine(DisplayName(DisplayDetails(i)));
}
