using SplashKitSDK;
using static SplashKitSDK.SplashKit;

// Open the window
Window window = OpenWindow("Free All Fonts Example", 900, 600);

// Load fonts from bundle
LoadResourceBundle("bundles", "Font.txt");

// Use FontA and FontB from bundle
ClearScreen(Color.White);
DrawText("This is Font A (Montserrat Black)", Color.Black, "FontA", 32, 100, 100);
DrawText("This is Font B (Montserrat Thin)", Color.Black, "FontB", 32, 100, 150);
RefreshScreen();
Delay(2000);

// Free fonts
FreeAllFonts();

// Load FontC manually after freeing others
LoadFont("FontC", "OpenSans_Condensed-Bold.ttf");

ClearScreen(Color.White);
DrawText("Fonts A and B were freed.", Color.Red, "FontC", 32, 100, 250);
DrawText("Now using Font C (OpenSans Condensed Bold)", Color.Red, "FontC", 32, 100, 300);
RefreshScreen();
Delay(2000);

// Close window
window.Close();
