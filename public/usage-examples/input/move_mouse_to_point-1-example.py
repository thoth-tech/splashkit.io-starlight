from splashkit import *

open_window("Move Mouse To Point", 800, 600)

# Define five target points using point_at to create point_2d values
# These represent the four corners and the center of the window
top_left     = point_at(100, 100)
top_right    = point_at(700, 100)
bottom_left  = point_at(100, 500)
bottom_right = point_at(700, 500)
center       = point_at(400, 300)

while not quit_requested():
    process_events()

    # move_mouse_to_point repositions the cursor to the given point_2d location
    # Each key press snaps the mouse to the corresponding target point
    if key_typed(KeyCode.q_key):
        move_mouse_to_point(top_left)
    if key_typed(KeyCode.e_key):
        move_mouse_to_point(top_right)
    if key_typed(KeyCode.a_key):
        move_mouse_to_point(bottom_left)
    if key_typed(KeyCode.d_key):
        move_mouse_to_point(bottom_right)
    if key_typed(KeyCode.space_key):
        move_mouse_to_point(center)

    clear_screen(color_white())

    # Draw a coloured circle at each target point so the user can see where the mouse will snap
    fill_circle(color_red(),    top_left.x,     top_left.y,     12)
    fill_circle(color_blue(),   top_right.x,    top_right.y,    12)
    fill_circle(color_green(),  bottom_left.x,  bottom_left.y,  12)
    fill_circle(color_orange(), bottom_right.x, bottom_right.y, 12)
    fill_circle(color_purple(), center.x,        center.y,        12)

    # Label each target with its corresponding key
    draw_text_font_as_string("[Q]",     color_red(),    "Arial", 16, top_left.x - 12,     top_left.y + 18)
    draw_text_font_as_string("[E]",     color_blue(),   "Arial", 16, top_right.x - 12,    top_right.y + 18)
    draw_text_font_as_string("[A]",     color_green(),  "Arial", 16, bottom_left.x - 12,  bottom_left.y + 18)
    draw_text_font_as_string("[D]",     color_orange(), "Arial", 16, bottom_right.x - 12, bottom_right.y + 18)
    draw_text_font_as_string("[SPACE]", color_purple(), "Arial", 16, center.x - 28,        center.y + 18)

    draw_text_font_as_string("Press a key to move the mouse to that point", color_black(), "Arial", 18, 185, 260)

    refresh_screen_with_target_fps(60)

close_all_windows()
