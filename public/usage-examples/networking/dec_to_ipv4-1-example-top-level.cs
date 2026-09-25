using static SplashKitSDK.SplashKit;

WriteLine("Hello! Welcome to the decimal to IPv4 converter.");

// Prompt the user for a decimal input
WriteLine("Please enter a decimal number (e.g., 2130706433):");

// Read the input as a string
string decInput = ReadLine();

// Convert the input string to an unsigned integer
uint decValue = Convert.ToUInt32(decInput);

// Convert the decimal value to a dotted decimal IPv4 address
string ipAddress = DecToIpv4(decValue);

// Display the result
WriteLine("The decimal value as an IPv4 address is: " + ipAddress);
