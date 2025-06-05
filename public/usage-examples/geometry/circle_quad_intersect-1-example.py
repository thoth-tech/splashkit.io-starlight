from splashkit import *

def main():
    open_window("Is the Circle inside the Quad?", 800, 600)

    font = load_font("Arial", "Arial.ttf")

    # Create an irregular quad
    fixed_quad = quad_from(
        300, 100,   # top-left
        500, 200,   # top-right
        200, 400,   # bottom-left
        600, 500    # bottom-right
    )

    # Initialize circle and visual state
    radius = 30
    mouse_circle = circle_at(point_at(0, 0), radius)
    quad_color = color_black()
    message = ""

    while not quit_requested():
        process_events()
        clear_screen(color_white())

        # Update circle to follow mouse
        mouse_pos = mouse_position()
        mouse_circle = circle_at(mouse_pos, radius)

        # Check intersection and update message/color
        if circle_quad_intersect(mouse_circle, fixed_quad):
            quad_color = color_green()
            message = "Yes, it is!"
        else:
            quad_color = color_red()
            message = "No, it isn't..."

        # Draw quad
        fill_quad(quad_color, fixed_quad)

        draw_text(message, color_black(), font, 24, 330, 300)
        
        draw_circle(color_black(), mouse_circle.center.x, mouse_circle.center.y, mouse_circle.radius)

        refresh_screen_with_target_fps(60)

main()