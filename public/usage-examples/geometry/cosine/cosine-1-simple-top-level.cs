using SplashKitSDK;
using static SplashKitSDK.SplashKit;

Write("Enter an angle: ");

// User inputs angle
float input = float.Parse(ReadLine());
float result = Cosine(input);

// Write cosine to console
Write("Cosine: ");
WriteLine(result);