from splashkit import *

open_window("Circle Click Display", 800, 600)

clicked_circle = "None"
click_count = 0

while not quit_requested():
    process_events()

    if mouse_clicked(MouseButton.left_button):
        mouse_point = mouse_position()

        if point_in_circle(mouse_point, circle_at_from_points(180, 250, 60)):
            clicked_circle = "Red"
            click_count += 1
        elif point_in_circle(mouse_point, circle_at_from_points(400, 250, 60)):
            clicked_circle = "Blue"
            click_count += 1
        elif point_in_circle(mouse_point, circle_at_from_points(620, 250, 60)):
            clicked_circle = "Green"
            click_count += 1

    clear_screen(color_white())

    draw_text_no_font_no_size("Click a circle to see which one was selected.", color_black(), 20, 20)
    draw_text_no_font_no_size("Last clicked: " + clicked_circle, color_black(), 20, 60)
    draw_text_no_font_no_size("Total clicks: " + str(click_count), color_black(), 20, 100)

    fill_circle(color_red(), 180, 250, 60)
    draw_circle(color_black(), 180, 250, 60)

    fill_circle(color_blue(), 400, 250, 60)
    draw_circle(color_black(), 400, 250, 60)

    fill_circle(color_green(), 620, 250, 60)
    draw_circle(color_black(), 620, 250, 60)

    draw_text_no_font_no_size("Red", color_black(), 155, 330)
    draw_text_no_font_no_size("Blue", color_black(), 375, 330)
    draw_text_no_font_no_size("Green", color_black(), 590, 330)

    refresh_screen_with_target_fps(60)

close_all_windows()