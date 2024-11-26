from splashkit import *

# Open a window for visualization
open_window("Transformation Matrix Visualization", 400, 400)
clear_screen(color_white())

# Define the scaling factors
matrix_scale = Point2D()
matrix_scale.x = 1.5  # Scale width by 1.5
matrix_scale.y = 1.2  # Scale height by 1.2

# Define the translation (shift by a small amount)
matrix_translation = Point2D()
matrix_translation.x = 20  # Shift right by 20 units
matrix_translation.y = -30 # Shift up by 30 units

# Define the rotation angle
rotation = 45

# Create a matrix combining scaling, rotation, and translation
transformation_matrix = scale_rotate_translate_matrix(matrix_scale, rotation, matrix_translation)

# Define the original triangle points (centered and larger)
# Top point
original_triangle = Triangle()
original_triangle.points[0] = Point2D()
original_triangle.points[0].x = 200
original_triangle.points[0].y = 150

# Bottom left point
original_triangle.points[1] = Point2D()
original_triangle.points[1].x = 150
original_triangle.points[1].y = 250

# Bottom right point
original_triangle.points[2] = Point2D()
original_triangle.points[2].x = 250
original_triangle.points[2].y = 250

# Draw the original triangle
fill_triangle_record(color_blue(), original_triangle)
write_line("Original (Blue) Triangle Points:")
for point in original_triangle.points:
    write_line(point_to_string(point))

# Transform the triangle using the transformation matrix
apply_matrix_to_triangle(transformation_matrix, original_triangle)

# Draw the transformed triangle
fill_triangle_record(color_red(), original_triangle)
write_line("Transformed (Red) Triangle Points:")
for point in original_triangle.points:
    write_line(point_to_string(point))

# Refresh the screen
refresh_screen()
delay(5000)

close_all_windows()
