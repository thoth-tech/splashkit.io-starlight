from splashkit import *

def main():
    window = open_window("Closest Point On Rect From Circle", 800, 600)

    # Rectangle for creating point on
    rectangle_obj = rectangle_from(300,200,200,150)

    while not window_close_requested(window):
        process_events()
        clear_screen(color_white())
        draw_rectangle_record(color_black(), rectangle_obj)

        # Create circle at mouse position to make it dynamic
        mouse_pos = mouse_position()
        circle_obj = circle_at(mouse_pos, 30)
        fill_circle_record(color_red(), circle_obj)

        # Get closest point on the rect to the circle and draw 
        closest_point = closest_point_on_rect_from_circle(circle_obj, rectangle_obj)
        point_on_rect = circle_at(closest_point, 5)
        fill_circle_record(color_green(), point_on_rect)

        refresh_screen()

    close_window(window)

main()
