using SplashKitSDK;
using static SplashKitSDK.SplashKit;

// Let user enter the text
WriteLine("Type some text: ");
string text = ReadLine();

// Let user enter the size
WriteLine("Enter the size for the text: ");
int size = ConvertToInteger(ReadLine());

OpenWindow("Text Width", 800, 600);
ClearScreen();

// Load a font
LoadFont("my_font", "arial.ttf");

//Calculate the text width with size enter by user
int textWidth = TextWidth(text, "my_font", size);

// Display the width of text.
WriteLine("The width of the text is: " + textWidth);

// Display the text in the window
DrawText(text, Color.Black, "my_font", size, 100, 100);

RefreshScreen();
Delay(4000);
CloseAllWindows();