using SplashKitSDK;
using static SplashKitSDK.SplashKit;

Write("Enter an angle: ");

// User inputs angle
double input = ConvertToDouble(ReadLine());
float result = Cosine((float)input);

// Write cosine to console
Write("Cosine: ");
WriteLine(result);