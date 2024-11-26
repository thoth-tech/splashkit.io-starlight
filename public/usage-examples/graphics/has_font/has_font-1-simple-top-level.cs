using SplashKitSDK;

SplashKit.OpenWindow("Has Font", 800, 600);
SplashKit.ClearScreen();

// Check if the font exists
bool fontCheck = HasFont("NORMAL_FONT");

// Display the result
if (fontCheck)
{
    DrawText("Font found!", Color.Black, 300, 300);
}
else
{
    DrawText("Font not found!", Color.Black, 300, 300);
}

RefreshScreen();
Delay(4000);
CloseAllWindows();
