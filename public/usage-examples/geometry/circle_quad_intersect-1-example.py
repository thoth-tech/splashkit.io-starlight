from splashkit import *

def main():
    open_window("Mouse Circle vs Rectangle Area", 800, 600)

    # Define the corners of a rectangular quad
    top_left = point_at(300, 200)
    top_right = point_at(500, 200)
    bottom_right = point_at(500, 400)
    bottom_left = point_at(300, 400)

    # Create the quad using the defined corner points
    fixed_quad = quad_from(
        top_left.x, top_left.y,
        top_right.x, top_right.y,
        bottom_right.x, bottom_right.y,
        bottom_left.x, bottom_left.y
    )

    radius = 30
    mouse_circle = circle_at(point_at(0, 0), radius)
    quad_color = color_black()

    while not quit_requested():
        process_events()
        clear_screen(color_white())

        mouse_pos = mouse_position()
        mouse_circle = circle_at(mouse_pos, radius)

        # Update quad color based on intersection with the circle
        if circle_quad_intersect(mouse_circle, fixed_quad):
            quad_color = color_red()
        else:
            quad_color = color_green()

        # Fill the quad using two colored triangles
        fill_triangle(quad_color, top_left.x, top_left.y, top_right.x, top_right.y, bottom_right.x, bottom_right.y)
        fill_triangle(quad_color, top_left.x, top_left.y, bottom_left.x, bottom_left.y, bottom_right.x, bottom_right.y)

        draw_circle(color_black(), mouse_circle.center.x, mouse_circle.center.y, radius)

        refresh_screen_with_target_fps(60)

main()