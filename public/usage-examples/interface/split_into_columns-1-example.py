from splashkit import *

open_window("Three Column Layout", 800, 600)

set_interface_style(InterfaceStyle.shaded_light_style)

while not quit_requested():
    process_events()

    clear_screen(color_white())

    if start_panel("Split Into Columns Demo", rectangle_from(40, 40, 600, 180)):
        start_custom_layout()

        split_into_columns(3)
        set_layout_height(64)

        button("Column 1")
        button("Column 2")
        button("Column 3")

        end_panel("Split Into Columns Demo")

    draw_interface()

    refresh_screen_with_target_fps(60)

close_all_windows()