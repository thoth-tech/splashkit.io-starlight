using static SplashKitSDK.SplashKit;

// Define the font name and required size.
string fontName = "Arial";
int requiredSize = 12;

// Check using the overload that takes a font name.
bool hasSizeByName = FontHasSize(fontName, requiredSize);

// Load a Font object with the required size.
Font myFont = new Font("Arial", 12);
bool hasSizeByObject = FontHasSize(myFont, requiredSize);

// Output the results.
WriteLine("Checking font using font name overload:");
WriteLine($"Font {fontName} with size {requiredSize}: " + (hasSizeByName ? "Yes" : "No"));

WriteLine("Checking font using font object overload:");
WriteLine($"Font {myFont.Name} with size {requiredSize}: " + (hasSizeByObject ? "Yes" : "No"));

// Keep the application running until the user quits.
while (!QuitRequested())
{
    ProcessEvents();
}
