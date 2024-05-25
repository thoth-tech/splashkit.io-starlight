using System;
using SplashKitSDK;

string text = "   Hello, World!   ";
string trimmedText = SplashKitSDK.SplashKit.Trim(text);

Console.WriteLine("Original: '" + text + "'");
Console.WriteLine("Trimmed: '" + trimmedText + "'");
