using SplashKitSDK;
using static SplashKitSDK.SplashKit;

string input = "Hello World";
string encoded = Base64Encode(input);

WriteLine("Original: " + input);
WriteLine("Encoded: " + encoded);