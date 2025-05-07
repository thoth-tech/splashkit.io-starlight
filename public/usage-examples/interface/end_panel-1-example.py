from splashkit import *

# Open a window
open_window("Panel Example", 600, 400)

while not quit_requested():
    process_events()
    clear_screen(color_white())

    # Define the panel
    panel_area = rectangle_from(50, 50, 500, 300)

    # Start the panel
    start_panel("MainPanel", panel_area)

    # Add Labels to the panel
    label_element("Hello, welcome to the panel example!")
    label_element("This panel is now finalized with end_panel()")

    # Finalize the panel - no more elements can be added after this point
    end_panel("MainPanel")

    # Draw the interface elements (all panels and labels)
    draw_interface()

    refresh_screen_with_target_fps(60)
