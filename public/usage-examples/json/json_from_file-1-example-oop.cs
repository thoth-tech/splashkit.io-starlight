using SplashKitSDK;
using static SplashKitSDK.SplashKit;

class JsonConfigLoadExample
{
    static void Main()
    {
        // Initialize audio system
        OpenAudio();
        
        // First, create a sample configuration file
        dynamic config = CreateJson();
        JsonSetString(config, "gameTitle", "My SplashKit Game");
        JsonSetNumber(config, "windowWidth", 800);
        JsonSetNumber(config, "windowHeight", 600);
        JsonSetNumber(config, "backgroundColor.r", 135);
        JsonSetNumber(config, "backgroundColor.g", 206);
        JsonSetNumber(config, "backgroundColor.b", 235);
        
        // Save the configuration to a file
        JsonToFile(config, "game_config.json");
        
        // Now demonstrate loading it back
        // This is what json_from_file does
        dynamic loadedConfig = JsonFromFile("game_config.json");
        
        // Extract the configuration values
        string gameTitle = JsonReadString(loadedConfig, "gameTitle");
        double windowWidth = JsonReadNumber(loadedConfig, "windowWidth");
        double windowHeight = JsonReadNumber(loadedConfig, "windowHeight");
        int bgRed = (int)JsonReadNumber(loadedConfig, "backgroundColor.r");
        int bgGreen = (int)JsonReadNumber(loadedConfig, "backgroundColor.g");
        int bgBlue = (int)JsonReadNumber(loadedConfig, "backgroundColor.b");
        
        // Create window with loaded dimensions
        OpenWindow(gameTitle, (int)windowWidth, (int)windowHeight);
        
        // Create a color from the loaded RGB values
        Color backgroundColor = RGBColor(bgRed, bgGreen, bgBlue);
        
        // Display the loaded configuration
        ClearScreen(backgroundColor);
        
        DrawText("Configuration Loaded Successfully!", ColorBlack(), 50, 50);
        DrawText("Game Title: " + gameTitle, ColorBlack(), 50, 100);
        DrawText("Window Size: " + windowWidth + "x" + windowHeight, ColorBlack(), 50, 150);
        DrawText("Background Color: RGB(" + bgRed + ", " + bgGreen + ", " + bgBlue + ")", ColorBlack(), 50, 200);
        
        RefreshScreen();
        
        // Wait 3 seconds before closing
        Delay(3000);
        
        // Cleanup
        CloseAllWindows();
        FreeJson(config);
        FreeJson(loadedConfig);
        CloseAudio();
    }
}