from splashkit import *

# Open window for the button font 
open_window("Button Interface Font", 800, 600)

# Load and register the Courier font for UI elements
load_font("courier", "courier.ttf")
set_interface_font_font_as_string("courier")

# Define a button area
btn_rect = rectangle_from(300, 250, 200, 60)

# Main loop: draw the button with our chosen interface font
while not quit_requested():
    process_events()
    clear_screen(color_white())

    # Draw a button labeled "Just a button" using the interface font
    button_at_position("Just a button", btn_rect)

    # Render all interface elements
    draw_interface()
    refresh_screen_with_target_fps(60)

close_all_windows()
