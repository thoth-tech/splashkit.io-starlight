using SplashKitSDK;
using static SplashKitSDK.SplashKit;

Write("Enter an angle: ");

// User inputs angle
float input = float.Parse(ReadLine());
float result = Tangent(input);

// Write tangent to console
Write("Tangent: ");
WriteLine(result);