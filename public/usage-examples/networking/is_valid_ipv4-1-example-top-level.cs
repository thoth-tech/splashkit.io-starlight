using static SplashKitSDK.SplashKit;

WriteLine("Hello! Welcome to the IPv4 address checker.");

// Prompt the user for an IP input in dotted decimal format
WriteLine("Please enter an IPv4 address in dotted decimal format (e.g., 192.168.0.1):");

// Read the input as a string
string ipInput = ReadLine();

// Check the address before trying to use it elsewhere
bool addressIsValid = IsValidIpv4(ipInput);

// Tell the user whether the address can be used
if (addressIsValid)
{
    WriteLine(ipInput + " is a valid IPv4 address.");
}
else
{
    WriteLine(ipInput + " is not a valid IPv4 address.");
}
