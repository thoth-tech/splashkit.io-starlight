using System;
using static SplashKitSDK.SplashKit;

uint firstIp = 2130706433;
uint secondIp = 3232235777;
uint thirdIp = 134744072;

// Convert decimal IP values into IPv4 addresses
string firstAddress = DecToIpv4(firstIp);
string secondAddress = DecToIpv4(secondIp);
string thirdAddress = DecToIpv4(thirdIp);

Console.WriteLine("Decimal to IPv4 Conversion");
Console.WriteLine();

Console.WriteLine(firstIp + " -> " + firstAddress);
Console.WriteLine(secondIp + " -> " + secondAddress);
Console.WriteLine(thirdIp + " -> " + thirdAddress);