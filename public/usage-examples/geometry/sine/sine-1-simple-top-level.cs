using SplashKitSDK;
using static SplashKitSDK.SplashKit;

Write("Enter an angle: ");

// User inputs angle
double input = ConvertToDouble(ReadLine());
float result = Sine((float)input);

// Write sine to console
Write("Sine: ");
WriteLine(result);