using SplashKitSDK;
using static SplashKitSDK.SplashKit;


Window window = OpenWindow("Option Flip X ", 600, 600);

       
Bitmap bmp = LoadBitmap("Player", "character.png");

// Draw the original bitmap image at position (100, 300) in the window
DrawBitmap(bmp, 100, 300); 

// Draw the bitmap image flipped horizontally at position (500, 300)
DrawBitmap(bmp, 500, 300, OptionFlipX());

RefreshScreen();

Delay(5000);

CloseAllWindows();
 
