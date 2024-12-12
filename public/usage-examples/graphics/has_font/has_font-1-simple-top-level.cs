using static SplashKitSDK.SplashKit;
 
// Load a font
LoadFont("my_font", "arial.ttf");
 
// Check if the font exists
bool fontCheck = HasFont("my_font");
 
// Display the result
if (fontCheck)
{
    WriteLine("Font found!");
}
else
{
    WriteLine("Font not found!");
}