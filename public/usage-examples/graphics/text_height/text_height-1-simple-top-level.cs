using SplashKitSDK;
using static SplashKitSDK.SplashKit;

// Let user enter the text
WriteLine("Type some text: ");
string text = ReadLine();

// Let user enter the size
WriteLine("Enter the size for the text: ");
int size = ConvertToInteger(ReadLine());

OpenWindow("Text Height", 800, 600);
ClearScreen();

// Load a font
LoadFont("my_font", "arial.ttf");

//Calculate the text height with size enter by user
int textHeight = TextHeight(text, "my_font", size);

// Display the height of text.
WriteLine("The height of the text is: " + textHeight);

// Display the text in the window
DrawText(text, Color.Black, "my_font", size, 100, 100);

RefreshScreen();
Delay(4000);
CloseAllWindows();

