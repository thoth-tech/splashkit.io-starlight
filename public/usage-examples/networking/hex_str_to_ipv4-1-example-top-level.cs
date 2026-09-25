using static SplashKitSDK.SplashKit;

WriteLine("Hello! Welcome to the hexadecimal to IPv4 converter.");

// Prompt the user for a hexadecimal input, which must start with 0x
WriteLine("Please enter a hexadecimal IPv4 string (e.g., 0x7F000001):");

// Read the input as a string
string hexInput = ReadLine();

// Convert the hexadecimal string to a dotted decimal IPv4 address
string ipAddress = HexStrToIpv4(hexInput);

// Display the result
WriteLine("The hexadecimal string as an IPv4 address is: " + ipAddress);
