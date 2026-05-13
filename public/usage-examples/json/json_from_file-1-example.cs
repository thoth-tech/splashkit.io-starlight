using SplashKitSDK;

// Initialize audio system
SplashKit.OpenAudio();

// First, create a sample configuration file
dynamic config = SplashKit.CreateJson();
SplashKit.JsonSetString(config, "gameTitle", "My SplashKit Game");
SplashKit.JsonSetNumber(config, "windowWidth", 800);
SplashKit.JsonSetNumber(config, "windowHeight", 600);
SplashKit.JsonSetNumber(config, "backgroundColor.r", 135);
SplashKit.JsonSetNumber(config, "backgroundColor.g", 206);
SplashKit.JsonSetNumber(config, "backgroundColor.b", 235);

// Save the configuration to a file
SplashKit.JsonToFile(config, "game_config.json");

// Now demonstrate loading it back
// This is what json_from_file does
dynamic loadedConfig = SplashKit.JsonFromFile("game_config.json");

// Extract the configuration values
string gameTitle = SplashKit.JsonReadString(loadedConfig, "gameTitle");
double windowWidth = SplashKit.JsonReadNumber(loadedConfig, "windowWidth");
double windowHeight = SplashKit.JsonReadNumber(loadedConfig, "windowHeight");
int bgRed = (int)SplashKit.JsonReadNumber(loadedConfig, "backgroundColor.r");
int bgGreen = (int)SplashKit.JsonReadNumber(loadedConfig, "backgroundColor.g");
int bgBlue = (int)SplashKit.JsonReadNumber(loadedConfig, "backgroundColor.b");

// Create window with loaded dimensions
SplashKit.OpenWindow(gameTitle, (int)windowWidth, (int)windowHeight);

// Create a color from the loaded RGB values
Color backgroundColor = SplashKit.RGBColor(bgRed, bgGreen, bgBlue);

// Display the loaded configuration
SplashKit.ClearScreen(backgroundColor);

SplashKit.DrawText("Configuration Loaded Successfully!", SplashKit.ColorBlack(), 50, 50);
SplashKit.DrawText("Game Title: " + gameTitle, SplashKit.ColorBlack(), 50, 100);
SplashKit.DrawText("Window Size: " + windowWidth + "x" + windowHeight, SplashKit.ColorBlack(), 50, 150);
SplashKit.DrawText("Background Color: RGB(" + bgRed + ", " + bgGreen + ", " + bgBlue + ")", SplashKit.ColorBlack(), 50, 200);

SplashKit.RefreshScreen();

// Wait 3 seconds before closing
SplashKit.Delay(3000);

// Cleanup
SplashKit.CloseAllWindows();
SplashKit.FreeJson(config);
SplashKit.FreeJson(loadedConfig);
SplashKit.CloseAudio();