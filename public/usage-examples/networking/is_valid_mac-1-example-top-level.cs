using static SplashKitSDK.SplashKit;

WriteLine("Hello! Welcome to the MAC address checker.");

// Prompt the user for a MAC address in XX:XX:XX:XX:XX:XX format
WriteLine("Please enter a MAC address (e.g., 1A:2B:3C:4D:5E:6F):");

// Read the input as a string
string macInput = ReadLine();

// Check the address before trying to convert or store it
bool addressIsValid = IsValidMac(macInput);

// Tell the user whether the address can be used
if (addressIsValid)
{
    WriteLine(macInput + " is a valid MAC address.");
}
else
{
    WriteLine(macInput + " is not a valid MAC address.");
}
