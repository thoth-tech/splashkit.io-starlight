from splashkit import *

def main():
    # Open the window
    window = open_window("Circle Quad Intersect Example", 800, 600)

    # Define quad points
    top_left = point_at(300, 200)
    top_right = point_at(500, 200)
    bottom_right = point_at(500, 400)
    bottom_left = point_at(300, 400)

    # Create the quad using individual coordinates
    fixed_quad = quad_from(
        top_left.x, top_left.y,
        top_right.x, top_right.y,
        bottom_right.x, bottom_right.y,
        bottom_left.x, bottom_left.y
    )

    radius = 30

    while not window_close_requested(window):
        process_events()
        clear_screen(color_dark_slate_gray())

        # Mouse-following circle
        mouse_pos = mouse_position()
        center = point_at(mouse_pos.x, mouse_pos.y)
        mouse_circle = circle_at(center, radius)

        # Check for intersection
        if circle_quad_intersect(mouse_circle, fixed_quad):
            fill_triangle(color_red(),
                          top_left.x, top_left.y,
                          top_right.x, top_right.y,
                          bottom_right.x, bottom_right.y)
            fill_triangle(color_red(),
                          bottom_right.x, bottom_right.y,
                          bottom_left.x, bottom_left.y,
                          top_left.x, top_left.y)
        else:
            fill_triangle(color_green(),
                          top_left.x, top_left.y,
                          top_right.x, top_right.y,
                          bottom_right.x, bottom_right.y)
            fill_triangle(color_green(),
                          bottom_right.x, bottom_right.y,
                          bottom_left.x, bottom_left.y,
                          top_left.x, top_left.y)

        # Draw the circle
        draw_circle(color_white(), center.x, center.y, radius)

        # Refresh screen (no arguments)
        refresh_screen()

main()