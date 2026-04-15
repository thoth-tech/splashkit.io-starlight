using SplashKitSDK;
using static SplashKitSDK.SplashKit;

OpenWindow("Font Has Size", 900, 650);

Font arialFont = LoadFont("arial font", "arial.ttf");
Font robotoFont = LoadFont("roboto font", "Roboto-Regular.ttf");

int size1 = 16;
int size2 = 32;
int size3 = 64;

bool arialHas16 = FontHasSize(arialFont, size1);
bool arialHas32 = FontHasSize(arialFont, size2);
bool arialHas64 = FontHasSize(arialFont, size3);

bool robotoHas16 = FontHasSize(robotoFont, size1);
bool robotoHas32 = FontHasSize(robotoFont, size2);
bool robotoHas64 = FontHasSize(robotoFont, size3);

string arialResult16 = "Not Available";
string arialResult32 = "Not Available";
string arialResult64 = "Not Available";

string robotoResult16 = "Not Available";
string robotoResult32 = "Not Available";
string robotoResult64 = "Not Available";

if (arialHas16) arialResult16 = "Available";
if (arialHas32) arialResult32 = "Available";
if (arialHas64) arialResult64 = "Available";

if (robotoHas16) robotoResult16 = "Available";
if (robotoHas32) robotoResult32 = "Available";
if (robotoHas64) robotoResult64 = "Available";

while (!QuitRequested())
{
    ProcessEvents();
    ClearScreen(ColorWhite());

    DrawText("FontHasSize can be used to compare supported font sizes.", ColorBlack(), arialFont, 24, 20, 20);

    DrawText("Font: Arial", ColorBlue(), arialFont, 22, 20, 80);
    DrawText("Size 16: " + arialResult16, ColorBlack(), arialFont, 20, 40, 120);
    DrawText("Size 32: " + arialResult32, ColorBlack(), arialFont, 20, 40, 155);
    DrawText("Size 64: " + arialResult64, ColorBlack(), arialFont, 20, 40, 190);

    DrawText("Font: Roboto", ColorRed(), arialFont, 22, 20, 280);
    DrawText("Size 16: " + robotoResult16, ColorBlack(), arialFont, 20, 40, 320);
    DrawText("Size 32: " + robotoResult32, ColorBlack(), arialFont, 20, 40, 355);
    DrawText("Size 64: " + robotoResult64, ColorBlack(), arialFont, 20, 40, 390);

    DrawText("Different fonts may support different sizes.", ColorBlack(), arialFont, 20, 20, 500);

    RefreshScreen(60);
}

CloseAllWindows();