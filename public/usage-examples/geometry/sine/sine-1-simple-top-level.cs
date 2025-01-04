using SplashKitSDK;
using static SplashKitSDK.SplashKit;

Write("Enter an angle: ");

// User inputs angle
float input = float.Parse(ReadLine());
float result = Sine(input);

// Write sine to console
Write("Sine: ");
WriteLine(result);