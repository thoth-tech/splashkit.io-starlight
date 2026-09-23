#include "splashkit.h"
#include <iostream>

int main()
{
    // Initialize audio system
    open_audio();
    
    // First, create a sample configuration file
    // This would typically already exist in your project
    json config = create_json();
    json_set_string(config, "gameTitle", "My SplashKit Game");
    json_set_number(config, "windowWidth", 800);
    json_set_number(config, "windowHeight", 600);
    json_set_number(config, "backgroundColor.r", 135);
    json_set_number(config, "backgroundColor.g", 206);
    json_set_number(config, "backgroundColor.b", 235);
    
    // Save the configuration to a file
    json_to_file(config, "game_config.json");
    
    // Now demonstrate loading it back
    // This is what json_from_file does
    json loaded_config = json_from_file("game_config.json");
    
    // Extract the configuration values
    string game_title = json_read_string(loaded_config, "gameTitle");
    double window_width = json_read_number(loaded_config, "windowWidth");
    double window_height = json_read_number(loaded_config, "windowHeight");
    int bg_red = json_read_number(loaded_config, "backgroundColor.r");
    int bg_green = json_read_number(loaded_config, "backgroundColor.g");
    int bg_blue = json_read_number(loaded_config, "backgroundColor.b");
    
    // Create window with loaded dimensions
    open_window(game_title, window_width, window_height);
    
    // Create a color from the loaded RGB values
    color background_color = rgb_color(bg_red, bg_green, bg_blue);
    
    // Display the loaded configuration
    clear_screen(background_color);
    
    draw_text("Configuration Loaded Successfully!", COLOR_BLACK, 50, 50);
    draw_text("Game Title: " + game_title, COLOR_BLACK, 50, 100);
    draw_text("Window Size: " + to_string((int)window_width) + "x" + to_string((int)window_height), COLOR_BLACK, 50, 150);
    draw_text("Background Color: RGB(" + to_string(bg_red) + ", " + to_string(bg_green) + ", " + to_string(bg_blue) + ")", COLOR_BLACK, 50, 200);
    
    refresh_screen();
    
    // Wait 3 seconds before closing
    delay(3000);
    
    // Cleanup
    close_all_windows();
    free_json(config);
    free_json(loaded_config);
    close_audio();
    
    return 0;
}