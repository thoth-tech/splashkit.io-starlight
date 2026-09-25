from splashkit import *

open_window("Bitmap Canvas", 800, 600)

canvas = create_bitmap("canvas", 500, 300)

clear_bitmap(canvas, color_white())

draw_rectangle_on_bitmap(canvas, color_red(), 20, 20, 120, 80)
draw_rectangle_on_bitmap(canvas, color_blue(), 170, 50, 150, 100)
draw_rectangle_on_bitmap(canvas, color_green(), 360, 30, 100, 200)

while not quit_requested():
    process_events()
    clear_screen(color_light_gray())

    draw_text_no_font_no_size(
        "These rectangles were drawn onto a bitmap first.",
        color_black(),
        20,
        20
    )

    draw_text_no_font_no_size(
        "The bitmap is then drawn to the window.",
        color_black(),
        20,
        50
    )

    draw_bitmap(canvas, 150, 180)

    refresh_screen_with_target_fps(60)

close_all_windows()
