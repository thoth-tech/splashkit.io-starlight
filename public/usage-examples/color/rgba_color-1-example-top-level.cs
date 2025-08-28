using SplashKitSDK;
using static SplashKitSDK.SplashKit;

OpenWindow("Rgba Color", 800, 600);

int random_red = new Random().Next(0, 255);
int random_green = new Random().Next(0, 255);
int random_blue = new Random().Next(0, 255);
// Function used here ↓
Color color = RGBAColor(random_red, random_green, random_blue, 255);
Rectangle rectangle = RectangleFrom(200, 100, 400, 300);

ClearScreen(ColorWhite());
FillRectangle(color, rectangle);
DrawText("Current color details: R-" + random_red.ToString() + ", G-" + random_green.ToString() + ", B-" + random_blue.ToString(), ColorBlack(), 235, 450);
RefreshScreen();

Delay(5000);

CloseAllWindows();