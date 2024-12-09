using SplashKitSDK;
using static SplashKitSDK.SplashKit;

Font myFont = null;

// Check if program has font
Write("Font available before loading: ");
WriteLine(HasFont(myFont).ToString());

// Load font
myFont = LoadFont("MyFont", "RobotoSlab.ttf");

// Check if program has font again
Write("Font available after loading: ");
WriteLine(HasFont(myFont).ToString());