from splashkit import *

open_window("Mouse Position Arrow", 800, 600)

while not quit_requested():
    process_events()

    # The vector runs from the window origin (the top-left corner) to the mouse
    mouse_vector = mouse_position_vector()

    clear_screen(color_white())

    draw_line(color_blue(), 0, 0, mouse_vector.x, mouse_vector.y)

    # Two short lines swept back from the tip make the arrowhead
    arrow_angle = vector_angle(mouse_vector)
    head_left = vector_from_angle(arrow_angle + 150, 25)
    head_right = vector_from_angle(arrow_angle - 150, 25)
    draw_line(color_blue(), mouse_vector.x, mouse_vector.y, mouse_vector.x + head_left.x, mouse_vector.y + head_left.y)
    draw_line(color_blue(), mouse_vector.x, mouse_vector.y, mouse_vector.x + head_right.x, mouse_vector.y + head_right.y)

    draw_text_no_font_no_size("Move the mouse to aim the arrow from the corner.", color_black(), 20, 510)
    draw_text_no_font_no_size("Vector X: " + str(int(mouse_vector.x)), color_black(), 20, 540)
    draw_text_no_font_no_size("Vector Y: " + str(int(mouse_vector.y)), color_black(), 20, 570)

    refresh_screen_with_target_fps(60)

close_all_windows()
