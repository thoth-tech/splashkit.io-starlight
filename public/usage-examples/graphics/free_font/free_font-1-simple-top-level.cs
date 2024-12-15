using SplashKitSDK;
using static SplashKitSDK.SplashKit;

// Open new window
Window wnd = OpenWindow("Font Styles", 600, 500);

// Load first font
Font font1 = LoadFont("BebasNeue", "BebasNeue.ttf");

// Draw text with font 
DrawTextOnWindow(wnd, "This font is called Bebas Neue", ColorBlack(), font1, 30, 150, 210);
DrawTextOnWindow(wnd, "The font style is Regular 400", ColorBlack(), font1, 30, 150, 240);
RefreshScreen();

Delay(3000);

// Free font1
FreeFont(font1);

// Clear Screen
ClearScreen();

// Load second font
Font font2 = LoadFont("NunitoSans", "NunitoSans.ttf");

// Draw text with font
DrawTextOnWindow(wnd, "This font is called Nunito Sans", ColorBlack(), font2, 30, 120, 210);
DrawTextOnWindow(wnd, "The font style is Extra Light 200", ColorBlack(), font2, 30, 120, 240);
RefreshScreen();

Delay(3000);

// Free font2
FreeFont(font2);

// Close window
CloseAllWindows();  
