from splashkit import *

heading_text = "Interface Labels"
first_label = "Welcome to SplashKit"
second_label = "This is a label element"

open_window("Simple Interface Layout", 800, 600)

set_interface_style(SHADED_LIGHT_STYLE)

while not quit_requested():
    process_events()

    clear_screen(COLOR_WHITE)

    # Labels are grouped together to form a simple interface section.
    label_element_at_position(heading_text, rectangle_from(320, 300, 400, 40))
    label_element_at_position(first_label, rectangle_from(300, 250, 400, 40))
    label_element_at_position(second_label, rectangle_from(300, 200, 400, 40))
    

    draw_interface()

    refresh_screen(60)

close_all_windows()