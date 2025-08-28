using SplashKitSDK;
using static SplashKitSDK.SplashKit;

OpenWindow("String To Color", 800, 600);

// Change this string to get different colors 
string color_hex = "#921e64d9";
// Function used here ↓
Color color = StringToColor(color_hex);
int red_component = RedOf(color);
int green_component = GreenOf(color);
int blue_component = BlueOf(color);
Rectangle rectangle = RectangleFrom(200, 100, 400, 300);

ClearScreen(ColorWhite());
FillRectangle(color, rectangle);
DrawText("Current color's RGBA hex value is " + color_hex, ColorBlack(), 235, 450);
DrawText("It's RGB values are: R-" + red_component.ToString() + ", G-" + green_component.ToString() + ", B-" + blue_component.ToString(), ColorBlack(), 235, 470);
RefreshScreen();

Delay(5000);

CloseAllWindows();