from splashkit import *

# Create a JSON object with a color string
json_obj = create_json()
json_set_string(json_obj, "color", "#8040FFFF")  # Purple

# Convert the JSON object to a color
clr = json_to_color(json_obj)

# Display the color components
write_line("Color created from JSON:")
write_line("Red: " + str(red_of(clr)))
write_line("Green: " + str(green_of(clr)))
write_line("Blue: " + str(blue_of(clr)))
write_line("Alpha: " + str(alpha_of(clr)))

# Free the JSON object
free_json(json_obj)