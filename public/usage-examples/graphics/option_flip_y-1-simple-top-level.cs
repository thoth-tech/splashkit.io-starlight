using SplashKitSDK;
using static SplashKitSDK.SplashKit;

  
Window window = OpenWindow("Option Flip Y ", 600, 600);


Bitmap bmp = LoadBitmap("Landscape", "landscape.png");

// Draw the original bitmap image at position (100, 300)
DrawBitmap(bmp, 100, 300); 

// Draw the bitmap image flipped horizontally at position (400, 300)
DrawBitmap(bmp, 400, 300, OptionFlipY());
       
RefreshScreen();
     
Delay(5000);

CloseAllWindows();
    

