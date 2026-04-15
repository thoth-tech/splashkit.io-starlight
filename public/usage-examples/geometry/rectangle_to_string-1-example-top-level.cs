using SplashKitSDK;
using static SplashKitSDK.SplashKit;

Rectangle rect = RectangleFrom(10, 20, 100, 50);
string result = RectangleToString(rect);

Console.WriteLine(result);