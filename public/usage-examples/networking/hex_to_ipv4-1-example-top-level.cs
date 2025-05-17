using SplashKitSDK;
using static SplashKitSDK.SplashKit;

WriteLine("Welcome to the hexadecimal to ipv4 converter.");

// Prompt the user for a hexadecimal input
WriteLine("Please enter a hexadecimal number:");

// Read the input as a string
string hex_input = ReadLine();

// Convert the hexadecimal string to ipv4
string ipv4_value = HexStrToIpv4(hex_input);

// Display the result
WriteLine("The hexadecimal value in ipv4 format is: " + ipv4_value);
