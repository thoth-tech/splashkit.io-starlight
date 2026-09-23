using static SplashKitSDK.SplashKit;

WriteLine("Hello! Welcome to the MAC address to hexadecimal converter.");

// Prompt the user for a MAC address in XX:XX:XX:XX:XX:XX format
WriteLine("Please enter a MAC address (e.g., 1A:2B:3C:4D:5E:6F):");

// Read the input as a string
string macInput = ReadLine();

// Convert the MAC address to hexadecimal format
string macAsHex = MacToHex(macInput);

// Display the result
WriteLine("The MAC address in hexadecimal format is: " + macAsHex);
