using static SplashKitSDK.SplashKit;


// Get number of displays
int numDisplays = NumberOfDisplays();
string dispName = DisplayName(DisplayDetails(0));

// Print main display name and number of displays
WriteLine($"The name of your main display is: {dispName}");
WriteLine($"You have {numDisplays} displays connected.");

// Print names of secondary displays
WriteLine("Your secondary displays are called: ");
for (uint i = 1; i < numDisplays; i++)
{
    dispName = DisplayName(DisplayDetails(i));
    WriteLine(dispName);
}
