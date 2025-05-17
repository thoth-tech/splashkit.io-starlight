using SplashKitSDK;
using static SplashKitSDK.SplashKit;

WriteLine("Welcome to the hexadecimal to Dec converter.");

// Prompt the user for a hexadecimal input
WriteLine("Please enter a hexadecimal number:");

// Read the input as a string
string hex_input = ReadLine();

// Convert the hexadecimal string to dec
string dec_value = HexToDecString(hex_input);

// Display the result
WriteLine("The hexadecimal value in dec format is: " + dec_value);
