from splashkit import *

open_window("Mouse Height Gauge", 800, 600)

while not quit_requested():
    process_events()

    # Read the height once so the line, the bar and the text always agree
    pointer_height = mouse_y()

    clear_screen(color_white())

    # The bar grows from the bottom of the window up to the pointer
    fill_rectangle(color_blue(), 340, pointer_height, 120, 600 - pointer_height)
    draw_line(color_red(), 0, pointer_height, 800, pointer_height)

    draw_text_no_font_no_size("Move the mouse up and down to change the gauge.", color_black(), 20, 20)
    draw_text_no_font_no_size("Mouse Y: " + str(int(pointer_height)), color_black(), 20, 60)

    refresh_screen_with_target_fps(60)

close_all_windows()
