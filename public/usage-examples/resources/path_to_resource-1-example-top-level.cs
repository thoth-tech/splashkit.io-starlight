using static SplashKitSDK.SplashKit;
using SplashKitSDK;

string resourcePath = PathToResource(
    "example.png",
    ResourceKind.ImageResource
);

WriteLine("Image resource path: " + resourcePath);