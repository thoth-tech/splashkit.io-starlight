from splashkit import *

# Create a color
clr = color_black()

# Convert the color to a JSON object
json_object = json_from_color(clr)

# Display the JSON object as a string
write_line("JSON from Color: " + json_to_string(json_object))