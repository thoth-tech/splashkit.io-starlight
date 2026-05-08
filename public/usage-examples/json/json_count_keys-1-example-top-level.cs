using SplashKitSDK;
using static SplashKitSDK.SplashKit;

Json j = CreateJson();

JsonSetString(j, "name", "Alex");
JsonSetString(j, "score", "95");
JsonSetString(j, "level", "3");

Console.WriteLine($"Top-level key count: {JsonCountKeys(j)}");