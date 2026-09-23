using SplashKitSDK;
using static SplashKitSDK.SplashKit;

// open window
OpenWindow("Greatest Common Divisor Example", 640, 360);

// define two numbers
int numA = 48;
int numB = 18;

// calculate gcd using splashkit function
int result = GCD(numA, numB);

while (!QuitRequested())
{
    ProcessEvents();
    ClearScreen(ColorWhite());

    // heading
    DrawText("Calculating the Greatest Common Divisor (GCD)", ColorBlue(), 60, 40);

    // numbers
    DrawText($"Number A: {numA}", ColorBlack(), 80, 100);
    DrawText($"Number B: {numB}", ColorBlack(), 80, 140);

    // result
    DrawText($"GCD Result: {result}", ColorRed(), 80, 200);

    // exit instructions
    DrawText("Press ESC to exit", ColorGray(), 420, 330);

    RefreshScreen();
}

CloseAllWindows();
