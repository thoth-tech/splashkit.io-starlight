using SplashKitSDK;

string text = "Hello SplashKit";

// Encode a plain string into Base64
string encoded = SplashKit.Base64Encode(text);

// Display the original and encoded values
SplashKit.WriteLine("Original: " + text);
SplashKit.WriteLine("Base64: " + encoded);
