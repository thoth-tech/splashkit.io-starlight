from splashkit import *

open_window("Dot Product of Vectors", 800, 600)

# Use one shared starting point for both vectors
origin = point_at(400, 300)

# Create two vectors with different directions
first_vector = vector_to(150, -100)
second_vector = vector_to(200, 80)

while not quit_requested():
    process_events()

    # Calculate the dot product of the two vectors
    result = dot_product(first_vector, second_vector)

    clear_screen(color_white())

    # Draw both vectors from the same origin point
    draw_line(color_blue(), origin.x, origin.y, origin.x + first_vector.x, origin.y + first_vector.y)
    draw_line(color_red(), origin.x, origin.y, origin.x + second_vector.x, origin.y + second_vector.y)

    # Label the vectors and show the dot product value
    draw_text_no_font_no_size("Blue vector", color_blue(), 520, 180)
    draw_text_no_font_no_size("Red vector", color_red(), 560, 390)
    draw_text_no_font_no_size("Dot product: " + format(result, ".2f"), color_black(), 260, 40)

    refresh_screen_with_target_fps(60)

close_all_windows()