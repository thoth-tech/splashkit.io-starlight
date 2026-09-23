using static SplashKitSDK.SplashKit;

WriteLine("Hello! Welcome to the hexadecimal to MAC address converter.");

// Prompt the user for a hexadecimal input, which must start with 0x
WriteLine("Please enter a hexadecimal MAC string (e.g., 0x1A2B3C4D5E6F):");

// Read the input as a string
string hexInput = ReadLine();

// Convert the hexadecimal string to a colon separated MAC address
string macAddress = HexToMac(hexInput);

// Display the result
WriteLine("The hexadecimal string as a MAC address is: " + macAddress);
