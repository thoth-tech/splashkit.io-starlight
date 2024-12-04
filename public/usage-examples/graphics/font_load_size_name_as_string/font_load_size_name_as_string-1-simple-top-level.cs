using static SplashKitSDK.SplashKit;
using SplashKitSDK;
// Load font and size 
LoadFont("BebasNeue", "BebasNeue.ttf");
FontLoadSize("BebasNeue", 20);

// Prompt user 
Write("What size would you like to check?: ");
string input = ReadLine();

// Convert input to integer 
int size = ConvertToInteger(input);
bool isSize = FontHasSize("BebasNeue", size);

// If user input is size of font 
if(isSize)
{
    WriteLine("APPROVED");
    WriteLine("Current font size is " + input);
}
else // If user input is not size of font
{
    WriteLine("ERROR");
    WriteLine("Font size is NOT " + input);
}