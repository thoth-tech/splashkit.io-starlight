using static SplashKitSDK.SplashKit;

// Get display width
int width = DisplayWidth(DisplayDetails(0));

// Open window with same width of display
OpenWindow("Display Width Exmaple", width, 100);
ClearScreen(ColorBlack());

// Write on window the display width
DrawText($"Display Width: {width}", ColorWhite(), width / 2, 50);
RefreshScreen();
while (!QuitRequested()) ProcessEvents();