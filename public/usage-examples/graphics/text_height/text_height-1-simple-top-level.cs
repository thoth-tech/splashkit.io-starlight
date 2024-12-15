using SplashKitSDK;
using static SplashKitSDK.SplashKit;

OpenWindow("Text Height", 800, 600);

ClearScreen();

string text = "Text Height!";

// Load a font
LoadFont("my_font", "arial.ttf");

//Calculate the text height with size = 16
int textHeight = TextHeight(text, "my_font", 16);

//Calculate the y position to make the text align it vertically in the window
int xPosition = 200;
int yPosition = (600 - textHeight) / 2;

// Display the text align it vertically in the window
DrawText(text, Color.Black, xPosition, yPosition);

RefreshScreen();
Delay(4000);
CloseAllWindows();

