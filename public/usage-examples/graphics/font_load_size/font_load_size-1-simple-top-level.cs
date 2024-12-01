using static SplashKitSDK.SplashKit;
using SplashKitSDK;
// Load font and size 
Font font1 = LoadFont("BebasNeue", "BebasNeue.ttf");
FontLoadSize(font1, 20);

// Prompt user 
Write("What size would you like to check?: ");
string input = ReadLine();

// Convert input to integer 
int size = ConvertToInteger(input);
bool isSize = FontHasSize(font1, size);

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