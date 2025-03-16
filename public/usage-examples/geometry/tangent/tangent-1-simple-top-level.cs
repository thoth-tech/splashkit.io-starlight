using SplashKitSDK;
using static SplashKitSDK.SplashKit;

Write("Enter an angle: ");

// User inputs angle
double input = ConvertToDouble(ReadLine());
float result = Tangent((float)input);

// Write tangent to console
Write("Tangent: ");
WriteLine(result);