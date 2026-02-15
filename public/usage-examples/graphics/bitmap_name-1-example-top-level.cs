using SplashKitSDK;
using static SplashKitSDK.SplashKit;

// Open a window titled "Bitmap Named Example" with fixed size
OpenWindow("Bitmap Named Example", 800, 600);

// Load the bitmap from file and assign it the name "logo"
LoadBitmap("logo", "splashkit.png");

// Retrieve the bitmap using the assigned name
Bitmap image = BitmapNamed("logo");

// Calculate the center position for the bitmap
float x = (800 - BitmapWidth(image)) / 2;
float y = (600 - BitmapHeight(image)) / 2;

// Clear the screen with a white background
ClearScreen(ColorWhite());

// Draw the bitmap in the center of the screen
DrawBitmap(image, x, y);

// Output the bitmap name to the terminal
WriteLine("Bitmap name: " + BitmapName(image));

// Show the final result at 60 FPS
RefreshScreen();
Delay(3000);