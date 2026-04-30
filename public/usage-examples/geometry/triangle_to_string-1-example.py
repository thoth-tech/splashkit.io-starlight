from splashkit import *

open_window("Triangle To String", 800, 600)

# Create a triangle to describe
demo_triangle = triangle_from(
    point_at(300, 200),
    point_at(500, 200),
    point_at(400, 400)
)

while not quit_requested():
    process_events()

    # Convert the triangle into a text description
    triangle_text = triangle_to_string(demo_triangle)

    clear_screen(color_white())

    # Draw the triangle
    draw_triangle(
        color_blue(),
        demo_triangle.points[0].x,
        demo_triangle.points[0].y,
        demo_triangle.points[1].x,
        demo_triangle.points[1].y,
        demo_triangle.points[2].x,
        demo_triangle.points[2].y
    )

    # Display the generated text
    draw_text_no_font_no_size(
        "Triangle description:",
        color_black(),
        20,
        20
    )

    draw_text_no_font_no_size(
        triangle_text,
        color_black(),
        20,
        50
    )

    refresh_screen()