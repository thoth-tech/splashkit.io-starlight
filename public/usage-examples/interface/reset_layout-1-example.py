from splashkit import *

open_window("Resetting Interface Layout", 800, 600)

set_interface_style(SHADED_LIGHT_STYLE)

while not quit_requested():
    process_events()

    clear_screen(COLOR_WHITE)

    if start_panel("Layout Reset Demo", rectangle_from(40, 40, 500, 400)):
        start_custom_layout()

        label_element("Before reset")

        split_into_columns(3)
        set_layout_height(64)

        button("One")
        button("Two")
        button("Three")

        # Resetting returns the interface to the default single-column layout.
        reset_layout()

        label_element("Default Layout After Reset")

        button("Default Layout 1")
        button("Default Layout 2")
        button("Default Layout 3")

        end_panel("Layout Reset Demo")

    draw_interface()

    refresh_screen(60)

close_all_windows()