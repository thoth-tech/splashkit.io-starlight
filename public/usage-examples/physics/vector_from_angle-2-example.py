from splashkit import *

open_window("Vector From Angle", 800, 600)

angle = 0
length = 180

while not quit_requested():
    process_events()

    if key_down(KeyCode.left_key):
        angle -= 2

    if key_down(KeyCode.right_key):
        angle += 2

    center_x = screen_width() / 2
    center_y = screen_height() / 2

    direction = vector_from_angle(angle, length)

    end_x = center_x + direction.x
    end_y = center_y + direction.y

    clear_screen(color_black())

    draw_line(color_blue(), center_x, center_y, end_x, end_y)
    fill_circle(color_yellow(), end_x, end_y, 10)
    fill_circle(color_white(), center_x, center_y, 6)

    draw_text_no_font_no_size(f"Angle: {angle:.0f} degrees", color_white(), 20, 20)
    draw_text_no_font_no_size(
        "Use Left and Right Arrow Keys",
        color_white(),
        20,
        50
    )

    refresh_screen_with_target_fps(60)

close_all_windows()