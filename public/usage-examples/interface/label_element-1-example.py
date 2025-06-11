from splashkit import *

# Open a window
open_window("SplashKit Interface Demo", 600, 400)

while not quit_requested():
    process_events()
    clear_screen(color_white())
    
    # Define the main panel
    main_panel_area = rectangle_from(50, 50, 500, 300)

    # Create the panel
    start_panel("MainPanel", main_panel_area)

    # Add label to the panel
    label_element("Welcome to the SplashKit Interface!")
    end_panel("MainPanel")

    # Draw all panels and interface elements
    draw_interface()

    refresh_screen_with_target_fps(60)
