from splashkit import *

open_window("Intruder Alert!!", 800, 600)

p1 = point_at(400, 200)
p2 = point_at(300, 400)
p3 = point_at(500, 400)
house = triangle_from(p1, p2, p3)
cursor_position = Point2D
intruder = Circle
flash = color_red()

while not quit_requested():
    process_events()

    # Get mouse position
    cursor_position = mouse_position()
    intruder = circle_at(cursor_position, 20)

    if circle_triangle_intersect(intruder, house):
        clear_screen(flash)
        draw_text_no_font_no_size("House Breached!!", color_black(), 350, 100)

        # Toggle flash color
        if flash == color_red():
            flash = color_blue()
        else:
            flash = color_red()

        delay(500)
    else:
        clear_screen(color_white())

    # Draw the house and intruder
    draw_triangle_record(color_black(), house)
    fill_circle_record(color_black(), intruder)
    refresh_screen()

close_all_windows()