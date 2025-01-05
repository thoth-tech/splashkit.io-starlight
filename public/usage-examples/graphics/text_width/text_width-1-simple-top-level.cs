using SplashKitSDK;
using static SplashKitSDK.SplashKit;

OpenWindow("Text Width", 800, 600);

ClearScreen();

string text = "Text Width!";

// Load font
LoadFont("my_font", "arial.ttf");

// Calculate the text width, 0 for arial.ttf, and 16 is the font size
int textWidth = TextWidth(text, "my_font", 16);

// Calculate the x and y position to make the text in the centre of the window
int xPosition = (800 - textWidth) / 2;
int yPosition = 600 / 2;

// Display the text in the centre of the window
DrawText(text, Color.Black, "my_font", 16, xPosition, yPosition);

RefreshScreen();
Delay(4000);
CloseAllWindows();

