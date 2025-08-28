using SplashKitSDK;
using static SplashKitSDK.SplashKit;

OpenWindow("Random Color", 800, 600);

// Function used here ↓
Color color = RandomColor();
int redComponent = RedOf(color);
int greenComponent = GreenOf(color);
int blueComponent = BlueOf(color);
int alphaComponent = AlphaOf(color);
Rectangle rectangle = RectangleFrom(200, 100, 400, 300);

ClearScreen(ColorWhite());
FillRectangle(color, rectangle);
DrawText("This random color's RGBA values are: R-" + redComponent.ToString() + ", G-" + greenComponent.ToString() + ", B-" + blueComponent.ToString() + ", A-" + alphaComponent.ToString(), ColorBlack(), 160, 450);
RefreshScreen();

Delay(5000);

CloseAllWindows();