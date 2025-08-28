using SplashKitSDK;
using static SplashKitSDK.SplashKit;

OpenWindow("Saturation Of", 800, 600);

int randomRed = new Random().Next(0, 255);
int randomGreen = new Random().Next(0, 255);
int randomBlue = new Random().Next(0, 255);
Color color = RGBAColor(randomRed, randomGreen, randomBlue, 255);
// Function used here ↓
double colorSaturation = SaturationOf(color);
Rectangle rectangle = RectangleFrom(200, 100, 400, 300);

ClearScreen(ColorWhite());
FillRectangle(color, rectangle);
DrawText("This color's saturation is " + colorSaturation.ToString(), ColorBlack(), 235, 450);
DrawText("It's RGBA values are: R-" + randomRed.ToString() + ", G-" + randomGreen.ToString() + ", B-" + randomBlue.ToString() + ", A-255", ColorBlack(), 235, 470);
RefreshScreen();

Delay(5000);

CloseAllWindows();