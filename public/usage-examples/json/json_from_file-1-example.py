from splashkit import *

# Initialize audio system
open_audio()

# First, create a sample configuration file
config = create_json()
json_set_string(config, "gameTitle", "My SplashKit Game")
json_set_number_integer(config, "windowWidth", 800)
json_set_number_integer(config, "windowHeight", 600)
json_set_number_integer(config, "backgroundColor.r", 135)
json_set_number_integer(config, "backgroundColor.g", 206)
json_set_number_integer(config, "backgroundColor.b", 235)

# Save the configuration to a file
json_to_file(config, "game_config.json")

# Now demonstrate loading it back
# This is what json_from_file does
loaded_config = json_from_file("game_config.json")

# Extract the configuration values
game_title = json_read_string(loaded_config, "gameTitle")
window_width = json_read_number(loaded_config, "windowWidth")
window_height = json_read_number(loaded_config, "windowHeight")
bg_red = int(json_read_number(loaded_config, "backgroundColor.r"))
bg_green = int(json_read_number(loaded_config, "backgroundColor.g"))
bg_blue = int(json_read_number(loaded_config, "backgroundColor.b"))

# Create window with loaded dimensions
open_window(game_title, int(window_width), int(window_height))

# Create a color from the loaded RGB values
background_color = rgb_color(bg_red, bg_green, bg_blue)

# Display the loaded configuration
clear_screen(background_color)

draw_text_no_font_no_size("Configuration Loaded Successfully!", color_black(), 50, 50)
draw_text_no_font_no_size(f"Game Title: {game_title}", color_black(), 50, 100)
draw_text_no_font_no_size(f"Window Size: {int(window_width)}x{int(window_height)}", color_black(), 50, 150)
draw_text_no_font_no_size(f"Background Color: RGB({bg_red}, {bg_green}, {bg_blue})", color_black(), 50, 200)

refresh_screen()

# Wait 3 seconds before closing
delay(3000)

# Cleanup
close_all_windows()
free_json(config)
free_json(loaded_config)
close_audio()