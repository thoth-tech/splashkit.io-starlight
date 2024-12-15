using SplashKitSDK;
using static SplashKitSDK.SplashKit;

OpenWindow("Text Width", 800, 600);

ClearScreen();

string text = "Text Width!";

// Load a font
LoadFont("my_font", "arial.ttf");

//Calculate the text width with size = 16
int textWidth = TextWidth(text, "my_font", 16);

//Calculate the x and y position to make the text in the centre of the window
int xPosition = (800 - textWidth) / 2;
int yPosition = 600 / 2;

// Display the text in the centre of the window
DrawText(text, Color.Black, xPosition, yPosition);

RefreshScreen();
Delay(4000);
CloseAllWindows();

